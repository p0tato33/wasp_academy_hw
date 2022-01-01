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

namespace Numberbox
{
    class PLUS_MINUS : Border
    {
        private TextBox textBox;
        private Button upperButton;
        private Button lowerButton;
        private int str = 0;
        public static RoutedEvent ValueChanged = EventManager.RegisterRoutedEvent("ValueChange", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(PLUS_MINUS));

        public PLUS_MINUS() : base()
        {
            textBox = new TextBox()
            {
                Text = "0",
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top
            };
            textBox.TextChanged += OnTextChange;
            upperButton = new Button()
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Content = "+"
            };
            upperButton.Click += PlusOne;
            lowerButton = new Button()
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Content = "-"
            };
            lowerButton.Click += MinusOne;
            HorizontalAlignment = HorizontalAlignment.Left;
            VerticalAlignment = VerticalAlignment.Top;
        }

        new public double Height        //высота
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;
                textBox.Height = value;
                upperButton.Height = value / 2;
                lowerButton.Height = value / 2;
            }
        }

        new public double Width         //ширина
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
                textBox.Width = value * 0.6;
                upperButton.Width = value * 0.4;
                lowerButton.Width = value * 0.4;
            }
        }

        public int Content
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
                textBox.Text = str.ToString();
                OnValueChange();
            }
        }

        new public Thickness Margin         //маргин
        {
            get
            {
                return base.Margin;
            }
            set
            {
                base.Margin = value;
                Thickness temp = value;
                textBox.Margin = value;
                temp.Left += Width * 0.6;
                upperButton.Margin = temp;
                temp.Top += Height * 0.5;
                lowerButton.Margin = temp;
            }
        }

        override protected void OnVisualParentChanged(DependencyObject oldParent)
        {
            Grid grid = VisualParent as Grid;
            grid.Children.Add(textBox);
            grid.Children.Add(upperButton);
            grid.Children.Add(lowerButton);
        }

        public event RoutedEventHandler ValueChange
        {
            add
            {
                AddHandler(ValueChanged, value);
            }
            remove
            {
                RemoveHandler(ValueChanged, value);
            }
        }

        private void OnValueChange()        //cобытие value change
        {
            RaiseEvent(new RoutedEventArgs(ValueChanged, this));
        }

        private void OnTextChange(object source, TextChangedEventArgs eventArgs)
        {
            int buffer;
            if (((TextBox)source).Text == "")
            {
                Content = 0;
                ((TextBox)source).Text = "0";
            }
            else
            {
                try
                {
                    buffer = Convert.ToInt32(((TextBox)source).Text);
                    Content = buffer;
                }
                catch (FormatException exception)
                {
                    ((TextBox)source).Text = Content.ToString();
                }
            }
        }

        private void PlusPlus(object sender, RoutedEventArgs e)
        {
            Content += 1;
        }

        private void MinusMinus(object sender, RoutedEventArgs e)
        {
            Content -= 1;
        }
    }
}
