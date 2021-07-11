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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] colours = {"Navy", "Blue", "Aqua", "Teal", "Olive", "Green", "Lime", "Yellow", 
            "Orange", "Red", "Maroon", "Fuchsia", "Purple", "Black", "Silver", "Gray", "White"};
        Color[] colors = { Colors.Navy, Colors.Blue, Colors.Aqua, Colors.Teal, Colors.Olive,
                Colors.Green, Colors.Lime, Colors.Yellow, Colors.Orange, Colors.Red, Colors.Maroon,
            Colors.Fuchsia, Colors.Purple, Colors.Black, Colors.Silver, Colors.Gray, Colors.White};

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < colours.Length; i++)
            {
                var item = colours[i];
                Button button = new Button();
                button.Width = item.Length * 8 + 12;
                button.Height = 24;
                button.Content = item;
                button.Name = "Button" + item;
                button.Foreground = new SolidColorBrush(colors[i]);
                button.Margin = new Thickness(2);
                button.HorizontalAlignment = HorizontalAlignment.Left;
                button.VerticalAlignment = VerticalAlignment.Top;
                ButtonsGrid.Children.Add(button);
            }
        }
    }
}
