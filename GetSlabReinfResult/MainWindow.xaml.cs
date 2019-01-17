using System;
using System.Windows;

namespace GetSlabReinfResult
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                MessageBox.Show("Error App:" + e.ExceptionObject);  
            };
        }
    }
}
