using System;
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
            set { SetValue(ref _discription, value); OnPropertyChanged(nameof(Discription)); }
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
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            LegendItemViewModel p = obj as LegendItemViewModel;
            if ((LegendItemViewModel)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Discription == p.Discription) && (Areg == p.Areg) && (Color == p.Color);
        }

        public bool Equals(LegendItemViewModel p)
        {
            // If parameter is null return false:
            if ((LegendItemViewModel)p == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (Discription == p.Discription) && (Areg == p.Areg) && (Color == p.Color);
        }

        //public override int GetHashCode()
        //{
        //    return Discription.Length * Convert.ToInt32(Areg) + Color.A + Color.R + Color.G + Color.B;
        //}


    }
}
