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
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        Thickness margin;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            Ellipse el = new Ellipse();
            margin.Top = rnd.Next(1, 350);
            margin.Left = rnd.Next(1, 750); ;
            el.Margin = margin;
            el.Width = 50;
            el.Height = 50;
            el.VerticalAlignment = VerticalAlignment.Top;
            el.Fill = Brushes.Green;
            el.Stroke = Brushes.Blue;
            el.StrokeThickness = 1;
            el.MouseDown += ClickOnFigur;
            FigursCanvas.Children.Add(el);
        }
        private void Square_Click(object sender, RoutedEventArgs e)
        {
            Rectangle re = new Rectangle();
            margin.Top = rnd.Next(1, 350);
            margin.Left = rnd.Next(1, 750); ;
            re.Margin = margin;
            re.Width = 50;
            re.Height = 50;
            re.Fill = Brushes.Pink;
            re.Stroke = Brushes.Blue;
            re.StrokeThickness = 1;
            re.MouseDown += ClickOnFigur;
            FigursCanvas.Children.Add(re);
        }
        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            Point p1 = new Point(rnd.Next(0, 700), rnd.Next(0, 300));
            Point p2 = new Point(rnd.Next(0, 700), rnd.Next(0, 300));
            Point p3 = new Point(rnd.Next(0, 700), rnd.Next(0, 300));

            Polygon po = new Polygon();
            po.Stroke = Brushes.Black;
            po.Fill = Brushes.Yellow;
            po.StrokeThickness = 1;

            po.Points = new PointCollection() {p1, p2, p3};

            po.MouseDown += ClickOnFigur;
            FigursCanvas.Children.Add(po);

        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            FigursCanvas.Children.Clear();
        }
        private void ClickOnFigur(object sender, RoutedEventArgs e)
        {
            if (e.Source.GetType().ToString() == "System.Windows.Shapes.Ellipse")
            {
                Ellipse buff = (Ellipse)e.Source;

                InformWindow informWindow = new InformWindow(buff);
                informWindow.Show();

            }
            if (e.Source.GetType().ToString() == "System.Windows.Shapes.Rectangle")
            {
                Rectangle buff = (Rectangle)e.Source;

                InformWindow informWindow = new InformWindow(buff);
                informWindow.Show();
            }
            if (e.Source.GetType().ToString() == "System.Windows.Shapes.Polygon")
            {
                Polygon buff = (Polygon)e.Source;

                InformPolygonWindow informWindow = new InformPolygonWindow(buff);
                informWindow.Show();
            }
            //if (e.Source.GetType() is Ellipse)
            //{

            //}
            //else if (e.Source.GetType() is Rectangle)
            //{

            //}
            //else if (e.Source.ToString(). is Polygon)
            //{

            //}
            //else MessageBox.Show("Несоответствующий тип");
        }
    }
}
