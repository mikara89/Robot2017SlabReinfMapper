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
        public static DesignLegendViewModel Instanc => new DesignLegendViewModel();
    }

    public class LegendViewModel : BaseViewModel
    {
        public ICommand OpenCommand =>
            new ActionCommand(async p => await Open());
        public ICommand SaveCommand =>
            new ActionCommand(async p => await Save()); 

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
               LoadSaveFromToTextFile.SaveFile(this.ToString(),dialog.FileName);
        }

        private BindingList<LegendItemViewModel> _listOfLagendItems;
        public BindingList<LegendItemViewModel> ListOfLagendItems
        { get => _listOfLagendItems; set { SetValue(ref _listOfLagendItems, value); OnPropertyChanged(nameof(ListOfLagendItems)); } }

        public double MaxA { get; internal set; }
        public double MinA { get;internal set; }

        public LegendViewModel()

        {
            ListOfLagendItems = new BindingList<LegendItemViewModel>
            {
                new LegendItemViewModel
                {
                    Areg=0.01,
                    Color=Colors.Transparent,
                    Discription="none"
                },
                 new LegendItemViewModel
                {
                    Areg=3.35,
                    Color=Colors.Red,
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
            _listOfLagendItems.ListChanged += chengedHendler;
        }
        public LegendViewModel(double MaxA, double  MinA)

        {
            ListOfLagendItems = new BindingList<LegendItemViewModel>
            {
                new LegendItemViewModel
                {
                    Areg=0.01,
                    Color=Colors.Transparent,
                    Discription="none"
                },
                 new LegendItemViewModel
                {
                    Areg=3.35,
                    Color=Colors.Red,
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
            _listOfLagendItems.ListChanged += chengedHendler;
        }

        private void chengedHendler(object s, ListChangedEventArgs e)
        {
            _listOfLagendItems = new BindingList<LegendItemViewModel>(_listOfLagendItems.OrderBy(x => x.Areg).ToList());
            _listOfLagendItems.ListChanged += chengedHendler;
            OnPropertyChanged(nameof(ListOfLagendItems));
        }

        public override string ToString()
        {
            var text = "";

            ListOfLagendItems.ToList().ForEach(x =>
            {
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
                });

                ListOfLagendItems = new BindingList<LegendItemViewModel>(list);
                ListOfLagendItems.ListChanged += chengedHendler;
                
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid string for creating scale");
            }
        }
    }
}
