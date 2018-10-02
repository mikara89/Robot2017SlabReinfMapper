using System;
using System.Windows.Media;

namespace GetSlabReinfResult.ViewModel
{
    public class LegendItemViewModel : BaseViewModel 
    {
        private string _discription;
        private double _areg;
        private Color _color;

        public string Description
        {
            get => _discription;
            set
            {
                SetValue(ref _discription, value);
                OnPropertyChanged(nameof(Description));
            }
        }
        public double Areg
        {
            get => _areg;
            set { SetValue(ref _areg, value); OnPropertyChanged(nameof(Areg)); }
        }
        public Color Color
        {
            get => _color;
            set { SetValue(ref _color, value); OnPropertyChanged(nameof(Color)); }
        }

        public override bool Equals(object obj)
        {

            if (obj == null)
            {
                return false;
            }

            LegendItemViewModel p = obj as LegendItemViewModel;
            if ((LegendItemViewModel)p == null)
            {
                return false;
            }

            return (Description == p.Description) && (Areg == p.Areg) && (Color == p.Color);
        }
        public bool Equals(LegendItemViewModel p)
        {
            // If parameter is null return false:
            if ((LegendItemViewModel)p == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (Description == p.Description) && (Areg == p.Areg) && (Color == p.Color);
        }
        private void FromDisc()
        {
            if (Description.Contains("=") && Description.Contains("s") && Description.Contains("d"))
            {
                var s = Convert.ToDouble(Description.Split('s')[1]);
                var d = Convert.ToDouble(Description.Split('s')[0].Split('d')[1].Trim());

                Areg = Math.Round((Math.Pow(s, 2) * Math.PI / 4) / d, 2);
                Description = $"Ø{d}/{s}";
            }
        }
    }
}
