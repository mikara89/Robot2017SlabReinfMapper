using System.Windows.Controls;

namespace GetSlabReinfResult
{
    /// <summary>
    /// Interaction logic for LegendConrol.xaml
    /// </summary>
    public partial class LegendConrol : UserControl
    {
        public LegendConrol() 
        {
            InitializeComponent();
        }
        private void DataGridTextColumn_TargetUpdated(object s, System.EventArgs e)
        {
            var vm = DataContext as ViewModel.LegendViewModel;
            vm.FilterAndSortCommand.Execute(null);
        }
    }
}
