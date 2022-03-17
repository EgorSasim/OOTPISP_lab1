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

namespace ShapesMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Shape line = new Line(new Point(1,1), new Point(2,2));
            Shape rectangle = new Rectangle(new Point(1,1), new Point(1,5), new Point(2,5), new Point
                (2,1));
            Shape square = new Square(new Point(1, 1), new Point(1, 3), new Point(3, 3), new Point
                (3, 1));
            Shape circle = new Circle(new Point(1, 1), 45);
            Shape triangle = new Triangle(new Point(1, 1), new Point(1, 3), new Point(3, 3));
            Shape elipse = new Elipse(new Point(1, 1), 155, 45);


            MessageBox.Show(line.Draw());
            MessageBox.Show(rectangle.Draw()); 
            MessageBox.Show(square.Draw());
            MessageBox.Show(circle.Draw());
            MessageBox.Show(triangle.Draw());
            MessageBox.Show(elipse.Draw());
        }
    }
}
