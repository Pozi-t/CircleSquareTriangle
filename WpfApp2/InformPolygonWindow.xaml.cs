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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для InformPolygonWindow.xaml
    /// </summary>
    public partial class InformPolygonWindow : Window
    {
        Polygon polygon;
        public InformPolygonWindow(Polygon po)
        {
            InitializeComponent();
            polygon = po;
            x1Text.Text = po.Points[0].X.ToString();
            y1Text.Text = po.Points[0].Y.ToString();
            x2Text.Text = po.Points[1].X.ToString();
            y2Text.Text = po.Points[1].Y.ToString();
            x3Text.Text = po.Points[2].X.ToString();
            y3Text.Text = po.Points[2].Y.ToString();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            polygon.Points[0] = new Point(double.Parse(x1Text.Text), double.Parse(y1Text.Text));
            polygon.Points[1] = new Point(double.Parse(x2Text.Text), double.Parse(y2Text.Text));
            polygon.Points[2] = new Point(double.Parse(x3Text.Text), double.Parse(y3Text.Text));
            this.Close();
        }
    }
}
