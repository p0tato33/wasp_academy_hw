using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Threading.Tasks;

namespace UNREALWPF
{
    public partial class MainWindow : Window
    {
        //поля
        private List<int> values;
        private readonly Random random;
        private readonly System.Windows.Threading.DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(ChangeColor);
            timer.Interval = new TimeSpan(0, 0, random.Next(5, 11));
            timer.Start();
        }

        //cобытия
        private void Btm_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            your_pin.Text += button.Content;
        }

        private void Btm_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ChangeColor();
            ChangeButtoms();
        }

        private void Btm_cancel_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor();
            ChangeButtoms();
            your_pin.Text = "";
        }

        private void Btm_enter_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor();
            ChangeButtoms();

            if (your_pin.Text.Length == Convert.ToInt32(pin_length.Text))
            {
                numbers.Visibility = Visibility.Hidden;
                btm_enter.Visibility = Visibility.Hidden;
                btm_cancel.Visibility = Visibility.Hidden;

                welcome.Visibility = Visibility.Visible;
            }
            else
            {
                your_pin.Text = "";
            }
        }

        private void Pin_length_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider)
            {
                pin_length.Text = Convert.ToInt32(slider.Value).ToString();
            }
        }


        private void ChangeButtoms()
        {
            values = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0
            };
            int MaxValue = 10;

            foreach (Button i in numbers.Children)
            {
                int val = values[random.Next(0, MaxValue)];
                i.Content = val;
                values.Remove(val);
                MaxValue--;
            }
        }
        //изменение цвета
        private void ChangeColor(object sender = null, EventArgs e = null)
        {
            foreach (Button i in numbers.Children)
            {
                i.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(random.Next(10, 230)), Convert.ToByte(random.Next(10, 230)),
                    Convert.ToByte(random.Next(10, 230)), Convert.ToByte(random.Next(10, 230))));
            }
        }

    }
}
