using GetSlabReinfResult.DataCollector.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using WinForms = System.Windows.Forms;

namespace GetSlabReinfResult.ViewModel
{
    public class DesignLegendViewModel: LegendViewModel
    {
        public DesignLegendViewModel(double MaxA, double MinA) : base(MaxA, MinA)
        {
        }

        public static DesignLegendViewModel Instanc => new DesignLegendViewModel(30,0);
    }

    public class LegendViewModel : BaseViewModel
    {
        #region Commands
        public ICommand OpenCommand =>
           new ActionCommand(async p => await Open());
        public ICommand SaveCommand =>
            new ActionCommand(async p => await Save());
        public ICommand ResetCommand =>
            new ActionCommand(async p => await Reset());
        public ICommand CellEditedCommand => 
           new ActionCommand(p => ListOfLagendItems.ToList().ForEach(x => x = FromDisc(x)));
        public ICommand AddRowCommand =>
          new ActionCommand(p => ListOfLagendItems.AddNew());
        public ICommand RemoveRowCommand =>
          new ActionCommand(p =>  ListOfLagendItems.Remove((p as LegendItemViewModel)));

        private async Task Reset()
        {
            PopulateTableDefault();
        }

        private async Task Open()
        {
            try
            {
                WinForms.OpenFileDialog dialog = new WinForms.OpenFileDialog();
                dialog.Filter= "Files | *.scl;";
                if (dialog.ShowDialog() == WinForms.DialogResult.OK)
                    PopulateTableFromString(LoadSaveFromToTextFile.ReadFile(dialog.FileName));
            }
            catch (Exception ex)
            {
                throw new Exception("Selected file invalid");
            }
            
        }
        private async Task Save()
        {
            try
            {
                WinForms.SaveFileDialog dialog = new WinForms.SaveFileDialog();
                dialog.Filter = "Files | *.scl;";
                dialog.DefaultExt = ".scl";
                if (dialog.ShowDialog() == WinForms.DialogResult.OK)
                    LoadSaveFromToTextFile.SaveFile(this.ToString(), dialog.FileName);
            }
            catch (Exception ex)
            {
                throw new Exception("Saving error");
            }
        }
        #endregion

        private BindingList<LegendItemViewModel> _listOfLagendItems;
        private double _maxA;
        private double _minA;
        public double MaxA { get => _maxA; internal set { _maxA = value; OnPropertyChanged(nameof(MaxA)); } }
        public double MinA { get => _minA; internal set { _minA = value; OnPropertyChanged(nameof(MinA)); } }
        


        public BindingList<LegendItemViewModel> ListOfLagendItems
        { get => _listOfLagendItems;
            set {
                SetValue(ref _listOfLagendItems, value);
                OnPropertyChanged(nameof(ListOfLagendItems));
            } }

        public LegendViewModel(double MaxA, double MinA)
        {
            this.MaxA = MaxA;
            this.MinA = MinA;
            PopulateTableDefault();
        }

        public LegendViewModel(double MaxA, double MinA, string text)
        {
            this.MaxA = MaxA;
            this.MinA = MinA;
            PopulateTableFromString(text);
        }

        private void AddNewItemHendler(object sender, AddingNewEventArgs e)
        {
            var r = new Random();
            var item = e.NewObject as LegendItemViewModel;
            item = new LegendItemViewModel();
            item.Areg =Math.Round( MinA+((MaxA-MinA) / 2),2);
            item.Description = "New"+(ListOfLagendItems.Where(x=>x.Description.Contains("New")).Count()+1.0);
            item.Color = Color.FromArgb
                (255,
                Convert.ToByte(r.Next(0, 256)), 
                Convert.ToByte(r.Next(0, 256)), 
                Convert.ToByte(r.Next(0, 256)));
            e.NewObject = item;
            Filter();
        }


        private void chengedHendler(object s, ListChangedEventArgs e)
        {
            SortList();
        }
        private void SortList()
        {
            ListOfLagendItems = new BindingList<LegendItemViewModel>(_listOfLagendItems.OrderBy(x => x.Areg).ToList());
            ListOfLagendItems.ListChanged += chengedHendler;
            ListOfLagendItems.AddingNew += AddNewItemHendler;
            Filter();
            OnPropertyChanged(nameof(ListOfLagendItems));
        }
        private void Filter()
        {
            var listToRemove = new List<LegendItemViewModel>();
            if (ListOfLagendItems.Any(x => x.Areg > ListOfLagendItems.First(y => y.Description == "Max").Areg)
                || ListOfLagendItems.Any(x => x.Areg < ListOfLagendItems.First(y => y.Description == "Min").Areg))
            {
                ListOfLagendItems.ToList().ForEach(i =>
                {
                    if (i.Areg > ListOfLagendItems.First(y => y.Description == "Max").Areg
                    || i.Areg < ListOfLagendItems.First(y => y.Description == "Min").Areg)
                        listToRemove.Add(i);
                });
                listToRemove.ForEach(x =>
                {
                    ListOfLagendItems.Remove(x);
                });
            }
        }

        private void PopulateTableDefault()
        {

            ListOfLagendItems = new BindingList<LegendItemViewModel>();
            var list = new List<LegendItemViewModel>
            {
                 new LegendItemViewModel
                {
                    Areg=3.35,
                    Color=Colors.LightPink,
                    Description="Ø8/15cm"
                },
                 new LegendItemViewModel
                {
                    Areg=5.24,
                    Color= Colors.Green,
                    Description="Ø10/15cm"
                },
                new LegendItemViewModel
                {
                    Areg=7.54,
                    Color= Colors.Magenta,
                    Description="Ø12/15cm"
                },
                new LegendItemViewModel
                {
                    Areg=10.26,
                    Color= Colors.Blue,
                    Description="Ø14/15cm"
                },
                new LegendItemViewModel
                {
                    Areg=13.4,
                    Color= Colors.Yellow,
                    Description="Ø16/15cm"
                },
                 new LegendItemViewModel
                {
                    Areg=16.96,
                    Color= Colors.WhiteSmoke,
                    Description="Ø18/15cm"
                },                 new LegendItemViewModel
                {
                    Areg=20.93,
                    Color= Colors.Teal,
                    Description="Ø20/15cm"
                },
            };
            var r = new Random();
            ///Adding min
            ListOfLagendItems.Add(new LegendItemViewModel
            {
                Areg =MinA+ 0.01,
                Color = Colors.Transparent,
                Description = "Min"
            });
            ///Adding Max
            ListOfLagendItems.Add(new LegendItemViewModel
            {
                Areg = MaxA,
                Description = "Max",
                Color = Colors.Red,
            });

            list.ForEach(i =>{
                if (!ListOfLagendItems.Any(x => x == i) && ListOfLagendItems.First(x => x.Description=="Max").Areg>i.Areg)
                {
                    ListOfLagendItems.Add(i);
                }
            });

            SortList();
        }



        public override string ToString()
        {
            var text = "";

            ListOfLagendItems.ToList().ForEach(x =>
            {
                if(x.Description!="Max" && x.Description != "Min")
                    text += $"{x.Description};{x.Areg};color{x.Color.A}:{x.Color.R}:{x.Color.G}:{x.Color.B}{Environment.NewLine}";
            });

            return text;
        }

        public List<LegendItemViewModel> PopulateTableFromString(string text)
        {
            var list = new List<LegendItemViewModel>();
            try
            {
                text.Split(Environment.NewLine.ToCharArray()).ToList().ForEach(x =>
                {
                    if (x != "")
                    {
                        var rows = x.Split(';');
                        if (rows[0] != "Max" && rows[0] != "Min")
                        {
                            var LI = new LegendItemViewModel
                            {
                                Description = rows[0],
                                Areg = Convert.ToDouble(rows[1]),
                                Color = Color.FromArgb(
                               Convert.ToByte(rows[2].Replace("color", "").Split(':')[0]),
                               Convert.ToByte(rows[2].Replace("color", "").Split(':')[1]),
                               Convert.ToByte(rows[2].Replace("color", "").Split(':')[2]),
                               Convert.ToByte(rows[2].Replace("color", "").Split(':')[3]))
                            };
                            list.Add(LI);
                        }
                    }
                });

                ///Adding min
                list.Add(new LegendItemViewModel
                {
                    Areg = MinA + 0.01,
                    Color = Colors.Transparent,
                    Description = "Min"
                });
                ///Adding Max
                list.Add(new LegendItemViewModel
                {
                    Areg = MaxA,
                    Description = "Max",
                    Color = Colors.Red,
                });
                
                ListOfLagendItems = new BindingList<LegendItemViewModel>(list);
                SortList();

                return list.OrderBy(x=>x.Areg).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid string for creating scale");
            }
        }

        private LegendItemViewModel FromDisc(LegendItemViewModel item)
        {
            if (item.Description.Contains("=") && item.Description.Contains("s") && item.Description.Contains("d"))
            {
                try
                {
                    var s = Convert.ToDouble(item.Description.Split('s')[1]);
                    var d = Convert.ToDouble(item.Description.Split('s')[0].Split('d')[1].Trim());

                    item.Areg = Math.Round((Math.Pow(d, 2) * Math.PI / 4) / s, 2);
                    item.Description = $"Ø{d}/{s}cm";
                }
                catch (Exception)
                {}

            }
            return item;
        }
    }
}
