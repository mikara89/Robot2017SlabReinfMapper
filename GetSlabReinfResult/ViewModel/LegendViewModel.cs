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

    //public class LegendViewModel : BaseViewModel
    //{
    //    #region Commands
    //    public ICommand OpenCommand =>
    //       new ActionCommand(async p => await Open());
    //    public ICommand SaveCommand =>
    //        new ActionCommand(async p => await Save());

    //    private async Task Open()
    //    {
    //        WinForms.OpenFileDialog dialog = new WinForms.OpenFileDialog();
    //        if (dialog.ShowDialog() == WinForms.DialogResult.OK)
    //            PopulateTableFromString(LoadSaveFromToTextFile.ReadFile(dialog.FileName));
    //    }
    //    private async Task Save()
    //    {
    //        WinForms.SaveFileDialog dialog = new WinForms.SaveFileDialog();
    //        dialog.DefaultExt = ".scl";
    //        if (dialog.ShowDialog() == WinForms.DialogResult.OK)
    //            LoadSaveFromToTextFile.SaveFile(this.ToString(), dialog.FileName);
    //    }
    //    #endregion

    //    public double MaxA { get; internal set; }
    //    public double MinA { get; internal set; }
    //    private BindingList<LegendItemViewModel> _listOfLagendItems;
    //    public BindingList<LegendItemViewModel> ListOfLagendItems
    //    { get => _listOfLagendItems; set { SetValue(ref _listOfLagendItems, value); OnPropertyChanged(nameof(ListOfLagendItems)); } }

        

    //    public LegendViewModel()

    //    {
    //        ListOfLagendItems = new BindingList<LegendItemViewModel>
    //        {
    //            new LegendItemViewModel
    //            {
    //                Areg=0.01,
    //                Color=Colors.Transparent,
    //                Discription="none"
    //            },
    //             new LegendItemViewModel
    //            {
    //                Areg=3.35,
    //                Color=Colors.Red,
    //                Discription="Ø8/15cm"
    //            },
    //             new LegendItemViewModel
    //            {
    //                Areg=5.24,
    //                Color= Colors.Green,
    //                Discription="Ø10/15cm"
    //            },
    //            new LegendItemViewModel
    //            {
    //                Areg=7.54,
    //                Color= Colors.Magenta,
    //                Discription="Ø12/15cm"
    //            },
    //            new LegendItemViewModel
    //            {
    //                Areg=10.26,
    //                Color= Colors.Blue,
    //                Discription="Ø14/15cm"
    //            },
    //            new LegendItemViewModel
    //            {
    //                Areg=13.4,
    //                Color= Colors.Yellow,
    //                Discription="Ø16/15cm"
    //            },
    //             new LegendItemViewModel
    //            {
    //                Areg=16.96,
    //                Color= Colors.WhiteSmoke,
    //                Discription="Ø18/15cm"
    //            },                 new LegendItemViewModel
    //            {
    //                Areg=20.93,
    //                Color= Colors.Teal,
    //                Discription="Ø20/15cm"
    //            },
    //        };
    //        _listOfLagendItems.ListChanged += chengedHendler;
    //    }
    //    public LegendViewModel(double MaxA, double  MinA)

    //    {
    //        ListOfLagendItems = new BindingList<LegendItemViewModel>
    //        {
    //            new LegendItemViewModel
    //            {
    //                Areg=0.01,
    //                Color=Colors.Transparent,
    //                Discription="none"
    //            },
    //             new LegendItemViewModel
    //            {
    //                Areg=3.35,
    //                Color=Colors.Red,
    //                Discription="Ø8/15cm"
    //            },
    //             new LegendItemViewModel
    //            {
    //                Areg=5.24,
    //                Color= Colors.Green,
    //                Discription="Ø10/15cm"
    //            },
    //            new LegendItemViewModel
    //            {
    //                Areg=7.54,
    //                Color= Colors.Magenta,
    //                Discription="Ø12/15cm"
    //            },
    //            new LegendItemViewModel
    //            {
    //                Areg=10.26,
    //                Color= Colors.Blue,
    //                Discription="Ø14/15cm"
    //            },
    //            new LegendItemViewModel
    //            {
    //                Areg=13.4,
    //                Color= Colors.Yellow,
    //                Discription="Ø16/15cm"
    //            },
    //             new LegendItemViewModel
    //            {
    //                Areg=16.96,
    //                Color= Colors.WhiteSmoke,
    //                Discription="Ø18/15cm"
    //            },                 new LegendItemViewModel
    //            {
    //                Areg=20.93,
    //                Color= Colors.Teal,
    //                Discription="Ø20/15cm"
    //            },
    //        };
    //        _listOfLagendItems.ListChanged += chengedHendler;
    //    }

    //    private void chengedHendler(object s, ListChangedEventArgs e)
    //    {
    //        _listOfLagendItems = new BindingList<LegendItemViewModel>(_listOfLagendItems.OrderBy(x => x.Areg).ToList());
    //        _listOfLagendItems.ListChanged += chengedHendler;
    //        OnPropertyChanged(nameof(ListOfLagendItems));
    //    }

    //    public override string ToString()
    //    {
    //        var text = "";

    //        ListOfLagendItems.ToList().ForEach(x =>
    //        {
    //            text += $"{x.Discription};{x.Areg};color{x.Color.A}:{x.Color.R}:{x.Color.G}:{x.Color.B}{Environment.NewLine}";
    //        });

    //        return text;
    //    }

    //    public List<LegendItemViewModel> PopulateTableFromString(string text)
    //    {
    //        var list = new List<LegendItemViewModel>();
    //        try
    //        {
    //            text.Split(Environment.NewLine.ToCharArray()).ToList().ForEach(x =>
    //            {
    //                if (x != "")
    //                {
    //                    var rows = x.Split(';');
    //                    var LI = new LegendItemViewModel
    //                    {
    //                        Discription = rows[0],
    //                        Areg = Convert.ToDouble(rows[1]),
    //                        Color = Color.FromArgb(
    //                            Convert.ToByte(rows[2].Replace("color", "").Split(':')[0]),
    //                            Convert.ToByte(rows[2].Replace("color", "").Split(':')[1]),
    //                            Convert.ToByte(rows[2].Replace("color", "").Split(':')[2]),
    //                            Convert.ToByte(rows[2].Replace("color", "").Split(':')[3]))
    //                    };
    //                    list.Add(LI);
    //                }
    //            });

    //            ListOfLagendItems = new BindingList<LegendItemViewModel>(list);
    //            ListOfLagendItems.ListChanged += chengedHendler;
                
    //            return list;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Invalid string for creating scale");
    //        }
    //    }
    //}

    public class LegendViewModel : BaseViewModel
    {
        #region Commands
        public ICommand OpenCommand =>
           new ActionCommand(async p => await Open());
        public ICommand SaveCommand =>
            new ActionCommand(async p => await Save());
        public ICommand ResetCommand =>
            new ActionCommand(async p => await Reset());

        private async Task Reset()
        {
            PopulateTableDefault();
        }

        private async Task Open()
        {
            WinForms.OpenFileDialog dialog = new WinForms.OpenFileDialog();
            if (dialog.ShowDialog() == WinForms.DialogResult.OK)
                PopulateTableFromString(LoadSaveFromToTextFile.ReadFile(dialog.FileName));
        }
        private async Task Save()
        {
            WinForms.SaveFileDialog dialog = new WinForms.SaveFileDialog();
            dialog.DefaultExt = ".scl";
            if (dialog.ShowDialog() == WinForms.DialogResult.OK)
                LoadSaveFromToTextFile.SaveFile(this.ToString(), dialog.FileName);
        }
        #endregion
        private BindingList<LegendItemViewModel> _listOfLagendItems;
        private double _maxA;
        private double _minA;

        public double MaxA { get => _maxA; internal set { _maxA = value; OnPropertyChanged(nameof(MaxA)); } }
        public double MinA { get => _minA; internal set { _minA = value; OnPropertyChanged(nameof(MinA)); } }
        


        public BindingList<LegendItemViewModel> ListOfLagendItems
        { get => _listOfLagendItems; set { SetValue(ref _listOfLagendItems, value); OnPropertyChanged(nameof(ListOfLagendItems)); } }


        public LegendViewModel(double MaxA, double MinA)
        {
            this.MaxA = MaxA;
            this.MinA = MinA;
            PopulateTableDefault();
        }

        private void AddNewItemHendler(object sender, AddingNewEventArgs e)
        {
            var r = new Random();
            var item = e.NewObject as LegendItemViewModel;
            item = new LegendItemViewModel();
            item.Areg =Math.Round( MinA+((MaxA-MinA) / 2),2);
            item.Discription = "New"+(ListOfLagendItems.Where(x=>x.Discription.Contains("New")).Count()+1.0);
            item.Color = Color.FromArgb(255, Convert.ToByte(r.Next(0, 256)), Convert.ToByte(r.Next(0, 256)), Convert.ToByte(r.Next(0, 256)));
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
            if (ListOfLagendItems.Any(x => x.Areg > ListOfLagendItems.First(y => y.Discription == "Max").Areg)
                || ListOfLagendItems.Any(x => x.Areg < ListOfLagendItems.First(y => y.Discription == "Min").Areg))
            {
                ListOfLagendItems.ToList().ForEach(i =>
                {
                    if (i.Areg > ListOfLagendItems.First(y => y.Discription == "Max").Areg
                    || i.Areg < ListOfLagendItems.First(y => y.Discription == "Min").Areg)
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
                    Discription="Ø8/15cm"
                },
                 new LegendItemViewModel
                {
                    Areg=5.24,
                    Color= Colors.Green,
                    Discription="Ø10/15cm"
                },
                new LegendItemViewModel
                {
                    Areg=7.54,
                    Color= Colors.Magenta,
                    Discription="Ø12/15cm"
                },
                new LegendItemViewModel
                {
                    Areg=10.26,
                    Color= Colors.Blue,
                    Discription="Ø14/15cm"
                },
                new LegendItemViewModel
                {
                    Areg=13.4,
                    Color= Colors.Yellow,
                    Discription="Ø16/15cm"
                },
                 new LegendItemViewModel
                {
                    Areg=16.96,
                    Color= Colors.WhiteSmoke,
                    Discription="Ø18/15cm"
                },                 new LegendItemViewModel
                {
                    Areg=20.93,
                    Color= Colors.Teal,
                    Discription="Ø20/15cm"
                },
            };
            var r = new Random();
            ///Adding min
            ListOfLagendItems.Add(new LegendItemViewModel
            {
                Areg =MinA+ 0.01,
                Color = Colors.Transparent,
                Discription = "Min"
            });
            ///Adding Max
            ListOfLagendItems.Add(new LegendItemViewModel
            {
                Areg = MaxA,
                Discription = "Max",
                Color = Colors.Red,
            });

            list.ForEach(i =>{
                if (!ListOfLagendItems.Any(x => x == i) && ListOfLagendItems.First(x => x.Discription=="Max").Areg>i.Areg)
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
                if(x.Discription!="Max" && x.Discription != "Min")
                    text += $"{x.Discription};{x.Areg};color{x.Color.A}:{x.Color.R}:{x.Color.G}:{x.Color.B}{Environment.NewLine}";
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
                                Discription = rows[0],
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
                    Discription = "Min"
                });
                ///Adding Max
                list.Add(new LegendItemViewModel
                {
                    Areg = MaxA,
                    Discription = "Max",
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
    }
}
