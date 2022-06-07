using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemoClicker
{
    internal class Clicker2 : StackPanel
    {
        private int _count = 0;
        private Label _label;

        public Clicker2() 
        {
            Orientation = Orientation.Horizontal;
            var button = new Button() { Content = "Trykk her!" };
            button.Click += ButtonClick;
            _label = new Label() { Content = "0" };
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
