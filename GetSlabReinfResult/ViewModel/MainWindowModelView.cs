using WinForms = System.Windows.Forms;
using GetSlabReinfResult.DataCollector.Logic;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Controls;
using GenerateIsolines;
using System.IO;

namespace GetSlabReinfResult.ViewModel 
{
    public class MainWindowModelView : BaseViewModel
    {
        public static MainWindowModelView DesignInstance { get; set; } = new MainWindowModelView()
        {
            legendViewModel = DesignLegendViewModel.Instanc,
            IsCollectorDone = true, 
        };

        private LegendViewModel _legendViewModel;
        private CancellationTokenSource ts;
        private CancellationToken ct;
        private bool _isCollectorDone;
        private IGetSlabReinfResult task;
        private string _FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) ;
        private string _filename="sample.dxf";
        private string _slabNumb;
        private int _Progress;
        private int _CountedObj;
        private string _ProgressString;
        private A_Type _AType=  A_Type.AX_TOP;
        private DrawAsType _DrawingAsType = DrawAsType.SOLID; 
        private double _SkipA=0;
        private double _Height=200;
        private bool _isDrawing;

        public MainWindowModelView()
        {}

        public ICommand CancelCommand => 
            new ActionCommand(async p => await Cancel());
        public ICommand GetDataCommand => 
            new ActionCommand(async prg =>{
                if (String.IsNullOrEmpty(SlabNumb) || String.IsNullOrEmpty(SlabNumb))
                    return;
                if (SlabNumb.ToLower() == "fake")
                    await GetDataAsyncFake();
                else await GetDataAsync();
            });
        public ICommand DrawCommand => 
            new ActionCommand(async prg => { IsDrawing = true; await DrawAsync(); IsDrawing = false; });
        public ICommand GetFilePathCommand =>
            new ActionCommand(prg => { GetFilePath(); });

        private void GetFilePath()
        {
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            if (dialog.ShowDialog() == WinForms.DialogResult.OK)
                FilePath = dialog.SelectedPath;
        }

        
        public double SkipA
        {
            get { return _SkipA; }
            set
            {
                SetValue(ref _SkipA, value);
                OnPropertyChanged(nameof(SkipA));
                SetLegend();
            }
        }
        public LegendViewModel legendViewModel
        {
            get { return _legendViewModel; }
            set { SetValue(ref _legendViewModel, value);
                OnPropertyChanged(nameof(legendViewModel));
                legendViewModel.ListOfLagendItems.AddingNew += (s, e) =>
                {
                    Height = 0;
                };
                
            }
        }
        public double Height
        {
            get { return _Height; }
            set
            {
                SetValue(ref _Height, value);
                if (IsCollectorDone) _Height = 260 + 37 * legendViewModel.ListOfLagendItems.Count;
                if (!IsCollectorDone) _Height = 200;
                OnPropertyChanged(nameof(Height));
            }
        }

        public bool IsCollectorDone
        {
            get { return _isCollectorDone; }
            set { SetValue(ref _isCollectorDone, value);
                OnPropertyChanged(nameof(IsCollectorDone));
                    Height =0;
            }
        }

        public bool IsDrawing
        {
            get { return _isDrawing; }
            set
            {
                SetValue(ref _isDrawing, value);
                OnPropertyChanged(nameof(IsDrawing));
            }
        }

        public string Filename
        {
            get { return _filename; }
            set
            {
                SetValue(ref _filename, value);
                OnPropertyChanged(nameof(Filename));
            }
        }
        public string FilePath
        {
            get { return _FilePath; }
            set { SetValue(ref _FilePath, value);
                OnPropertyChanged(nameof(FilePath)); }
        }
        public string SlabNumb
        {
            get { return _slabNumb; }
            set { SetValue(ref _slabNumb, value);
                Filename = $"{SlabNumb}-{FE.GetA_TypeAsString(AType)}.dxf";
                Reset();
                OnPropertyChanged(nameof(SlabNumb)); }
        }
        public int Progress
        {
            get { return _Progress; } 
            set { SetValue(ref _Progress, value);
                OnPropertyChanged(nameof(Progress));
            }
        }
        public string ProgressString
        {
            get { return _ProgressString; }
            set { SetValue(ref _ProgressString, value);
                OnPropertyChanged(nameof(ProgressString));
            }
        }
        public int CountedObj
        {
            get { return _CountedObj; }
            set
            {
                SetValue(ref _CountedObj, value);
                OnPropertyChanged(nameof(CountedObj));
            }
        }
        public A_Type AType
        {
            get { return _AType; }
            set
            {
                SetValue(ref _AType, value);
                Filename = $"{SlabNumb}-{FE.GetA_TypeAsString(AType)}.dxf";
                SetLegend();
                OnPropertyChanged(nameof(_AType));
            }
        }

        private void Reset()
        {
            if (IsCollectorDone)
                IsCollectorDone =!IsCollectorDone;

            if(task!=null)
            {
                task.Dispose();
                UpdateProgressText(new ProgressModelObject<double>());
            }
        }

        public DrawAsType DrawingAsType
        {
            get => _DrawingAsType;
            set { _DrawingAsType = value;
                OnPropertyChanged(nameof(DrawingAsType)); }
        }

        private async Task DrawAsync()
        {
           
            var scale = new GenerateIsolines.Model.Legend();
            scale.slabNumber = SlabNumb.ToString();
            scale.LegendOfType = FE.GetA_TypeAsString(AType);
            
            legendViewModel.ListOfLagendItems.ToList()
                .ForEach(x => scale.ListOfLagendItems.Add(
                
                new GenerateIsolines.Model.LegendItem
                {
                    Areg = x.Areg,
                    Color = new RSAColor(x.Color.R, x.Color.B, x.Color.G, x.Color.A),
                    Discription = x.Description,
                    
                }));
            try
            {
               await task.CreateDxfDrawingAsync(
                  FilePath + "\\" + Filename,
                  AType, 
                  SkipA,
                  scale,
                  DrawingAsType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message);
            }
        }

        private async Task GetDataAsync()
        {
            IsCollectorDone = false;
            try
            {
                ts = new CancellationTokenSource();
                ct = ts.Token;
                var prg = new Progress<ProgressModelObject<double>>();
                (prg as Progress<ProgressModelObject<double>>)
                    .ProgressChanged += (s, e) => UpdateProgressText(e);

                task = new DataCollector.Logic.GetSlabReinfResult(SlabNumb.ToIntArrayFromRobotStringSelection(),Services.RobotAppService.iapp);
                await task.StartAsync(prg, ct);

                if (!ct.IsCancellationRequested)
                {
                    SetLegend();
                    IsCollectorDone = true;
                }
                if (ct.IsCancellationRequested)
                    IsCollectorDone = false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task GetDataAsyncFake()
        {
            IsCollectorDone = false;
            try
            {
                ts = new CancellationTokenSource();
                ct = ts.Token;
                var prg = new Progress<ProgressModelObject<double>>();
                (prg as Progress<ProgressModelObject<double>>)
                    .ProgressChanged += (s, e) => UpdateProgressText(e);

                var panelPath = Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath)+ "\\panelFake.json";
                var panelEdgesPath = Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\\edgesFake.json";


                task = new DataCollector.Logic.GetSlabReinfResult(panelPath, panelEdgesPath);
                await task.StartFakeAsync(prg, ct);

                (prg as IProgress<ProgressModelObject<double>>)
                    .Report(new ProgressModelObject<double>
                    {
                        Progress = 100,
                        ProgressToString = "Fake Loaded"
                    });
                

                if (!ct.IsCancellationRequested)
                {
                    SetLegend();
                    IsCollectorDone = true;
                }
                if (ct.IsCancellationRequested)
                    IsCollectorDone = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SetLegend()
        {
            var min = task.Panel.Min(x => x.ExtremeMin(AType));

            var max = task.Panel.Max(x => x.ExtremeMax(AType));
            if (SkipA < max)
                legendViewModel = new LegendViewModel(max, min, SkipA);
            else legendViewModel = new LegendViewModel(max, min);
        }

        private async Task Cancel()
        {
            if (ts != null)
            {
                ts.Cancel();
                ts = new CancellationTokenSource();
            }
        }

        public void UpdateProgressText(ProgressModelObject<double> obj)
        {
            ProgressString = obj.ProgressToString;
            Progress = Convert.ToInt32(obj.Progress);
            CountedObj = Convert.ToInt32(obj.MaxValue);
        }
    }
}
