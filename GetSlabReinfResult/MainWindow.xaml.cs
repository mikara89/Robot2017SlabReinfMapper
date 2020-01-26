using System.ComponentModel;
using System.Windows;

namespace GetSlabReinfResult
{
    /// <summary>
    /// Interaction logic for ModalWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel.MainWindowModelView vm
        {
            get => DataContext as ViewModel.MainWindowModelView;
            set => DataContext = value;
        }
        public MainWindow() 
        {
            DataContext = new ViewModel.MainWindowModelView();
            InitializeComponent();
            this.Deactivated += Window_Deactivated;
            this.Activated += (s, e) =>
             {
                 vm.GetFocusedCommand.Execute(null);
                 txtBox.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White);
             };
        }
        
        private void Window_Deactivated(object sender, System.EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
            txtBox.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LawnGreen);
            vm.LostFocusedCommand.Execute(null);
        }
    }
}
