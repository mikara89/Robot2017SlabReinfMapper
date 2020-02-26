using GetSlabReinfResult.DataCollector.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TableTetaUI.Models;
using TableTetaUI.ViewModels.Table;

namespace TableTetaUI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public static MainWindowViewModel DesignInstance => new MainWindowViewModel
        {
            Tabel = new ThetaTableControlViewModel
        {
            new TableTetaModel{ Id=1, StoreyName="LVL -1", dr_x=0.001, dr_y=0.001, Fx= 1000, Fy=2000, Fz=5200, h=3},
            new TableTetaModel{ Id=2, StoreyName="LVL 0", dr_x=0.002, dr_y=0.002, Fx= 1000, Fy=2000, Fz=5200, h=4}
        },
            YDirCase = 6,
            XDirCase = 12,
            G_Psi_QCase = 1,
            IsLoading=false,
            ProgressString= "Faching data for X case direction..."
        };
        public ThetaTableControlViewModel Tabel;

        private int _XDirCase;
        private int _YDirCase;
        private int _G_Psi_QCase;
        private bool _IsLoading=false;
        private CancellationTokenSource ts;
        private string _ProgressString;


        public MainWindowViewModel()
        {
            Tabel = new ThetaTableControlViewModel();
            YDirCase = 6;
            XDirCase = 12;
            G_Psi_QCase = 18;
        }

        public string ProgressString
        {
            get { return _ProgressString; }
            set { SetValue(ref _ProgressString, value); }
        }

        public bool IsLoading
        {
            get { return _IsLoading; }
            set { SetValue(ref _IsLoading, value); }
        }

        public int XDirCase
        {
            get { return _XDirCase; }
            set { SetValue(ref _XDirCase, value); }
        }
        public int YDirCase
        {
            get { return _YDirCase; }
            set { SetValue(ref _YDirCase, value); }
        }
        public int G_Psi_QCase
        {
            get { return _G_Psi_QCase; }
            set { SetValue(ref _G_Psi_QCase, value); }
        }

        public ICommand CancelCommand =>
           new ActionCommand(async p => await CancelAsync());

        public ICommand ExportToExcelCommand =>
          new ActionCommand(p => MessageBox.Show($"Sorry not yet implemented?"));


        public ICommand LoadCommand =>
           new ActionCommand(async p => await LoadFakeAsync()); 

        private async Task CancelAsync()
        {
            if (ts!=null)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure that you want to cancel?", "Canceling", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        ts.Cancel();
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }
        }

        private async Task LoadAsync()
        {

            ts = new CancellationTokenSource();
            var ct = ts.Token;
            IProgress<ProgressModelObject<double>> prg = new Progress<ProgressModelObject<double>>();
            (prg as Progress<ProgressModelObject<double>>)
                .ProgressChanged += (s, e) => UpdateProgressText(e);

            var test = new GetResultForStorys(Services.RobotAppService.iapp);
            List<TableTetaModel> r = new List<TableTetaModel>();
            try
            {
                IsLoading = true;
                r = await Task.Run(() =>
                {
                    prg.Report(new ProgressModelObject<double> { ProgressToString = "Faching data for X case direction..." });
                    if (ct.IsCancellationRequested)
                        ct.ThrowIfCancellationRequested();
                    var X = test.QueryResultsForStorey(XDirCase, new Progress<ProgressModelObject<double>>(), default);
                    if (ct.IsCancellationRequested)
                        ct.ThrowIfCancellationRequested();
                    prg.Report(new ProgressModelObject<double> { ProgressToString = "Faching data for Y case direction..." });
                    var Y = test.QueryResultsForStorey(YDirCase, new Progress<ProgressModelObject<double>>(), default);
                    prg.Report(new ProgressModelObject<double> { ProgressToString = "Faching data for G+PsiQ case direction..." });
                    if (ct.IsCancellationRequested)
                        ct.ThrowIfCancellationRequested();
                    var P_tot = test.QueryResultsForStorey(G_Psi_QCase, new Progress<ProgressModelObject<double>>(), default, true);

                    test.SaveToJson(new Storys[] { X, Y, P_tot });

                    return TableTetaModel.Create(X, Y, P_tot).OrderByDescending(x => x.Id).ToList();
                }, ct);

                Tabel.Clear();
                prg.Report(new ProgressModelObject<double> { ProgressToString = "Filling table..." });
                foreach (var item in r)
                {
                   
                    Tabel.Add(item);
                }
            }
            catch (OperationCanceledException ex)
            {}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private void UpdateProgressText(ProgressModelObject<double> e)
        {
            ProgressString = e.ProgressToString;
        }

        private async Task LoadFakeAsync()
        {
            ts = new CancellationTokenSource();
            var ct = ts.Token;
            IProgress<ProgressModelObject<double>> prg = new Progress<ProgressModelObject<double>>();
            (prg as Progress<ProgressModelObject<double>>)
                .ProgressChanged += (s, e) => UpdateProgressText(e);

            var RobotDataCollector = new GetResultForStorys();
            Tabel.Clear();
            List<TableTetaModel> r = new List<TableTetaModel>();

            try
            {
                IsLoading = true;
                var stories = RobotDataCollector.ReadFromJson();
                r = await Task.Run(() =>
                 {
                     prg.Report(new ProgressModelObject<double> { ProgressToString = "Faching data from file..." });
                     Task.Delay(3000).Wait(ct);

                     return TableTetaModel.Create(stories[0], stories[1], stories[2]).OrderByDescending(x => x.Id).ToList();

                 },ct);
                Tabel.Clear();
                prg.Report(new ProgressModelObject<double> { ProgressToString = "Filling table..." });
                Task.Delay(2000).Wait(ct);
                foreach (var item in r)
                {
                    Tabel.Add(item);
                }
            }
            catch (OperationCanceledException ex)
            {}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                IsLoading = false;
            }


          
        }
        public void SaveToJson(BindingList<TableTetaModel> table)
        {
            var path = System.IO.Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\\tableMockData.xaml";
            using (StreamWriter file = File.CreateText(path))
            {
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(table.GetType());
                //serialize object directly into file stream
                ser.Serialize(file, table);
            }
        }


    }
}
