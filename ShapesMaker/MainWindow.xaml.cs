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

            Line line = new Line(new Point(100,200), new Point(700,200));
            Rectangle rectangle = new Rectangle(new Point(400, 50), new Point(400, 0), new Point(500, 0), new Point
                (500, 50));
            Square square = new Square(new Point(300, 50), new Point(300, 0), new Point(350, 0), new Point
                (350, 50));
            Circle circle = new Circle(new Point(200, 50), 50);
            Triangle triangle = new Triangle(new Point(600, 100), new Point(650, 50), new Point(700, 100));
            Elipse elipse = new Elipse(new Point(50, 50), 100, 50);

            // Message boxes to know the cirtain coordinates of my shapes
            MessageBox.Show(elipse.Draw());
            MessageBox.Show(circle.Draw());
            MessageBox.Show(square.Draw());
            MessageBox.Show(rectangle.Draw());
            MessageBox.Show(triangle.Draw());
            MessageBox.Show(line.Draw());

            // Create a canvas because Window.AddChild will throw exception when U add more than one 
            // object to it, because Window is a ContentControl. Page allowed only 1 chil, so this 
            // child will be a canv and I will place all other objects in canv;
            Canvas canv = new Canvas();

            //Line
            System.Windows.Shapes.Line lin = new System.Windows.Shapes.Line();
            lin.X1 = line.P1.X;
            lin.Y1 = line.P1.Y;
            lin.X2 = line.P2.X;
            lin.Y2 = line.P2.Y;
            lin.StrokeThickness = 4;          
            lin.Stroke = Brushes.Black;
          


            // Circle
            Ellipse circl = new Ellipse();
            circl.Width = circle.Diameter;
            circl.Height = circle.Diameter;
            Canvas.SetTop(circl, circle.P1.Y);
            Canvas.SetLeft(circl, circle.P1.X);
            circl.Fill = Brushes.WhiteSmoke;
            circl.Stroke = Brushes.DarkRed;


            // Ellipse
            Ellipse el = new Ellipse();
            el.Width = elipse.Width;
            el.Height = elipse.Height;
            Canvas.SetTop(el, elipse.P1.Y);
            Canvas.SetLeft(el, elipse.P1.X);
            el.Fill = Brushes.Green;
            el.Stroke = Brushes.Yellow;

            // Square
            System.Windows.Shapes.Rectangle squar = new System.Windows.Shapes.Rectangle();
            squar.Height = square.P1.Y - square.P2.Y;
            squar.Width = square.P3.X - square.P2.X;
            Canvas.SetTop(squar, square.P1.Y);
            Canvas.SetLeft(squar, square.P1.X);
            squar.Fill = Brushes.Aquamarine;
            squar.Stroke = Brushes.BurlyWood;

            // Rectangular
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle();
            rect.Height = rectangle.P1.Y - rectangle.P2.Y;
            rect.Width = rectangle.P3.X - rectangle.P2.X;
            Canvas.SetTop(rect, rectangle.P1.Y);
            Canvas.SetLeft(rect, rectangle.P1.X);
            rect.Fill = Brushes.Chocolate;
            rect.Stroke = Brushes.Coral;



            // Triangle(representis through polygon(cause learn C# only few hours))
            Polygon trian = new Polygon();
            trian.Fill = Brushes.Crimson;
            trian.Stroke = Brushes.DarkCyan;

            System.Windows.Point Point1 = new System.Windows.Point(triangle.P1.X, triangle.P1.Y);
            System.Windows.Point Point2 = new System.Windows.Point(triangle.P2.X, triangle.P2.Y);
            System.Windows.Point Point3 = new System.Windows.Point(triangle.P3.X, triangle.P3.Y);

            PointCollection trianPoints = new PointCollection();

            trianPoints.Add(Point1);
            trianPoints.Add(Point2);
            trianPoints.Add(Point3);
            
            trian.Points = trianPoints;


            // add shapes to canvas
            canv.Children.Add(lin);
            canv.Children.Add(circl);
            canv.Children.Add(el);
            canv.Children.Add(squar);
            canv.Children.Add(rect);
            canv.Children.Add(trian);


            this.Content = canv;

        }
    }
}
