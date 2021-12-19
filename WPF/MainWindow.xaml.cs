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
using System.Threading;

namespace UNREALWPF

{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string true_pin = "1096743";
        Color true_color = Color.FromArgb(60, 0, 255, 0);
        Color false_color = Color.FromArgb(60, 255, 0, 0);
        Color normal_color = Color.FromArgb(100, 33, 33, 37);
        static int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
//
        private void clck(object sender, RoutedEventArgs e)       //
        {
            if (count != 1)
            {
                enter.Text += (sender as Button).Content;
            }
        }

        private void clck2(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text = null;
            }
        }

        private async void if_clck(object sender, RoutedEventArgs e)
        {
            if (enter.Text == true_pin && count != 1)
            {
                enter.Text = "TRUE";
                enter.Background = new SolidColorBrush(true_color);
                enter.IsReadOnly = true;
                count = 1;
            }
            else if (count != 1)
            {
                enter.Background = new SolidColorBrush(false_color);
                enter.Text = "ERROR";
                await Task.Delay(1000);
                enter.Text = null;
                enter.Background = new SolidColorBrush(normal_color);
            }
        }

        private void key_down(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.D0) && (e.Key <= Key.D9)) e.Handled = false;
            if ((e.Key >= Key.NumPad0) && (e.Key <= Key.NumPad9)) e.Handled = false;
        }
    }
}
