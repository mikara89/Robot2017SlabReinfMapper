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
using TableTetaUI.ViewModels.Table;

namespace TableTetaUI.Controler.Tables
{
    /// <summary>
    /// Interaction logic for ThetaTableControl.xaml
    /// </summary>
    public partial class ThetaTableControl : UserControl
    {
        public ThetaTableControlViewModel vm {
            get
            {
                return this.DataContext as ThetaTableControlViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
        public ThetaTableControl()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            vm.RemoveCommand.Execute(dataGrid.SelectedItem as Models.TableTetaModel);
        }

        //    public string ItemSource 
        //    {
        //        get { return (string)GetValue(ItemSourceProperty); }
        //        set { SetValue(ItemSourceProperty, value); }
        //    }

        //    // Using a DependencyProperty as the backing store for TextFilePath.
        //    //This enables animation, styling, binding, etc...
        //    public static readonly DependencyProperty ItemSourceProperty =
        //        DependencyProperty.Register(
        //            "ItemSource",
        //            typeof(string),
        //            typeof(ThetaTableControl),
        //            new PropertyMetadata(""));
    }
}
