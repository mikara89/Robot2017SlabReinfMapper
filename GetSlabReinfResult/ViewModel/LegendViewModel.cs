using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media;

namespace GetSlabReinfResult.ViewModel
{
    public class DesignLegendViewModel: LegendViewModel
    {
        public static DesignLegendViewModel Instanc => new DesignLegendViewModel();
    }

    public class LegendViewModel : BaseViewModel
    {
        private BindingList<LegendItemViewModel> _listOfLagendItems;
        public BindingList<LegendItemViewModel> ListOfLagendItems
        { get => _listOfLagendItems; set { SetValue(ref _listOfLagendItems, value); } }

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
    }
}
