using System.Windows.Media;

namespace GetSlabReinfResult.ViewModel
{
    public class LegendItemViewModel : BaseViewModel 
    {
        private string _discription;
        private double _areg;
        private Color _color;

        public string Discription
        {
            get => _discription;
            set { SetValue(ref _discription, value); }
        }
        public double Areg
        {
            get => _areg;
            set { SetValue(ref _areg, value); }
        }
        public Color Color
        {
            get => _color;
            set { SetValue(ref _color, value); }
        }
    }
}
