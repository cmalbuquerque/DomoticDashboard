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
using System.Windows.Media.Animation;

namespace Aula01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("Hello world!");


        }

        private void doubleclick(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            double xPos = p.X;
            double yPos = p.Y;
            Console.WriteLine("The X position is " + xPos + " The Y position is " + yPos);
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Console.WriteLine("Hello button!");
           SolidColorBrush init_color = new SolidColorBrush(Colors.DarkGray);
           this.Background = init_color;
           ColorAnimation colorAnim = new ColorAnimation();
           colorAnim.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
           colorAnim.To = Colors.LightGray;
           init_color.BeginAnimation(SolidColorBrush.ColorProperty, colorAnim);
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
                Console.WriteLine("Right button");
        }



        
    }
}
