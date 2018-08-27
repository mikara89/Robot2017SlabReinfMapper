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

namespace GetSlabReinfResult.ViewModel 
{
    public class MainWindowModelView : BaseViewModel
    {
        //public static MainWindowModelView DesignInstance { get; set; } = new MainWindowModelView()
        //{
        //    legendViewModel = DesignLegendViewModel.Instanc,
        //    IsCollectorDone=true,
        //};

        private LegendViewModel _legendViewModel;
        private CancellationTokenSource ts;
        private CancellationToken ct;
        private bool _isCollectorDone;
        private GetSlabReinfResultClass task;
        private string _FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) ;
        private string _filename="sample.dxf";
        private int _slabNumb;
        private int _Progress;
        private int _CountedObj;
        private string _ProgressString;
        private A_Type _DrawingAType=  A_Type.AX_TOP;
        private double _SkipA=0;
        private double _Height=200;

        public MainWindowModelView()
        {
            //legendViewModel = new LegendViewModel();
            //legendViewModel.ListOfLagendItems.AddingNew += (s, e) =>
            //{
            //    Height = 0;
            //};
        }

        public ICommand CancelCommand => 
            new ActionCommand(async p => await Cancel());
        public ICommand GetDataCommand => 
            new ActionCommand(async prg =>{await GetDataAsync();});
        public ICommand DrawCommand => 
            new ActionCommand(prg => { Draw(); });
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
        public int SlabNumb
        {
            get { return _slabNumb; }
            set { SetValue(ref _slabNumb, value);
                Filename = $"{SlabNumb}-{FE.GetA_TypeAsString(DrawingAType)}.dxf";
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
        public A_Type DrawingAType
        {
            get { return _DrawingAType; }
            set
            {
                SetValue(ref _DrawingAType, value);
                Filename = $"{SlabNumb}-{FE.GetA_TypeAsString(DrawingAType)}.dxf";
                OnPropertyChanged(nameof(DrawingAType));
            }
        }

        private void Draw()
        {
            var l = new GenerateIsolines.Model.Legend();
            l.slabNumber = SlabNumb;
            l.LegendOfType = FE.GetA_TypeAsString(DrawingAType);
            
            legendViewModel.ListOfLagendItems.ToList()
                .ForEach(x => l.ListOfLagendItems.Add(
                
                new GenerateIsolines.Model.LegendItem
                {
                    Areg = x.Areg,
                    Color = new RSAColor(x.Color.R, x.Color.G, x.Color.B, x.Color.A),
                    Discription = x.Discription,
                    
                }));
            try
            {
                task.CreateDxfDrawing(
                  FilePath + "\\" + Filename,
                  DrawingAType, 
                  SkipA,
                  l);
                MessageBox.Show("Done","Work progress:");

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

                task = new GetSlabReinfResultClass(SlabNumb);
                await task.StartAsync(prg, ct);

                if (!ct.IsCancellationRequested)
                {
                    var min = task.Panel.Min(x => x.ExtremeMin(DrawingAType));
                    var max = task.Panel.Max(x => x.ExtremeMax(DrawingAType));
                    legendViewModel = new LegendViewModel(max, min);
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
