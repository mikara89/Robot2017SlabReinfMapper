using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TableTetaUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModels.MainWindowViewModel vm
        {
            get => DataContext as ViewModels.MainWindowViewModel;
            set => DataContext = value;
        }
        public MainWindow()
        {
            vm = new ViewModels.MainWindowViewModel();
            InitializeComponent();
            ThetaTable.SetBinding(UserControl.DataContextProperty, new Binding() {  Source=vm.Tabel});
        }
        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            
        }
    }
}
