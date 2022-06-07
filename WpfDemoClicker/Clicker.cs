using System.Windows;
using System.Windows.Controls;

namespace WpfDemoClicker
{
    internal class Clicker
    {
        private int _count = 0;
        private Label _label;
        public StackPanel Panel { get; private set; }

        public Clicker()
        {
            Panel = new StackPanel();
            var button = new Button() { Content = "Trykk her!" };
            button.Click += ButtonClick;
            _label = new Label() { Content = "0" };
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
