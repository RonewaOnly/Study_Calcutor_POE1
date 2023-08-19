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

namespace POE_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddModuleMethod(object sender, RoutedEventArgs e)
        {
            Title.Visibility = Visibility.Collapsed;
            ProgressBar loading = new ProgressBar();
            loading.Name = "loaded";
            loading.Width = 300;
            loading.Height = 10;
            loading.Visibility = Visibility.Visible;
            int i = 0;
            while (i != 100)
            {
                loading.Value = i;
                i++;
            }
            MainForm.Children.Add(loading);

            
        }

        private void ViewModuleMethod(object sender, RoutedEventArgs e)
        {

        }

        private void WindowLoaded(object sender, RoutedEventArgs e)//This method changes the Label from Collapsed to Visible
        {
            Title.Visibility = Visibility.Visible;
        }
    }
}
