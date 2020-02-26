using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTetaUI.ViewModels.Settings
{
    public class SettingsViewModel:BaseViewModel
    {
        private string _Theta_max;
        private string _Theta_nom;
        private string _Theta_min;

        public string Theta_max
        {
            get { return _Theta_max; }
            set { SetValue(ref _Theta_max, value); }
        }
        

        public string Theta_nom
        {
            get { return _Theta_nom; }
            set { SetValue(ref _Theta_nom, value); }
        }
        

        public string Theta_min
        {
            get { return _Theta_min; }
            set { SetValue(ref _Theta_min, value); }
        }
        private string _I_II_v;

        public string I_II_v
        {
            get { return _I_II_v; }
            set { SetValue(ref _I_II_v, value); }
        }
        private string _III_IV_v;

        public string III_IV_v
        {
            get { return _III_IV_v; }
            set { SetValue(ref _III_IV_v, value); }
        }
        public Models.CatOfObjectImportance objectImportance
    }
}
