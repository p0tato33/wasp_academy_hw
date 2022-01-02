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
using System.Windows.Threading;

namespace WPF_Practise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private static Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
            SetTimer();
        }

        private void SetTimer()
        {
            timer.Tick += OnTimedEvent;
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
        }

        private void MouseEnterAndMove(object sender, MouseEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Color.FromArgb((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255));
            ((Button)sender).Margin = new Thickness(rand.Next(0, 280), rand.Next(0, 260), 0, 0);
            ((Button)sender).Background = brush;
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            Button btn = new Button()
            {
                Content = "Press",
                Background = new SolidColorBrush(Color.FromArgb((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255))),
                Margin = new Thickness(rand.Next(0, 280), rand.Next(0, 260), 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                FontSize = 12,
                Height = 100,
                Width = 100
            };
            btn.MouseEnter += MouseEnterAndMove;
            btn.MouseMove += MouseEnterAndMove;
            mainGrid.Children.Add(btn);
        }
    }
}
