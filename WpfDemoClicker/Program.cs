using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemoClicker
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            //var clicker1 = new Clicker();
            //var clicker2 = new Clicker();

            //var p = new StackPanel();
            //p.Children.Add(clicker1.Panel);
            //p.Children.Add(clicker2.Panel);

            var clicker1 = new Clicker2();
            var clicker2 = new Clicker2();

            var p = new StackPanel();
            p.Children.Add(clicker1);
            p.Children.Add(clicker2);
            window.Content = p;
            app.Run(window);
        }
    }

    /*
    internal class Program
    {
        static int _count = 0;
        static Label _label;

        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var panel = new StackPanel();
            var button = new Button() { Content = "Trykk her!" };
            button.Click += ButtonClick;
            _label = new Label() { Content= "0"};
            panel.Children.Add(button);
            panel.Children.Add(_label);
            window.Content = panel;
            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
     */
}
