using System.Windows;

namespace GetSlabReinfResult
{
    /// <summary>
    /// Interaction logic for ModalWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow() 
        {
            InitializeComponent();
            this.Deactivated += Window_Deactivated;
            this.Activated += (s, e) =>
             {
                 (DataContext as ViewModel.MainWindowModelView).Focus = !(DataContext as ViewModel.MainWindowModelView).Focus;
                 (DataContext as ViewModel.MainWindowModelView).InitSelectionMonitoring();
                 txtBox.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White);

             };

        }

        private void Window_Deactivated(object sender, System.EventArgs e)
        {
            (DataContext as ViewModel.MainWindowModelView).Focus = false;
            (DataContext as ViewModel.MainWindowModelView).InitSelectionMonitoring();
            Window window = (Window)sender;
            window.Topmost = true;
            txtBox.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LawnGreen);
        }
    }
}
