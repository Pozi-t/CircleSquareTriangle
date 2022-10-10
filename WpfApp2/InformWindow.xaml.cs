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
    /// Логика взаимодействия для InformWindow.xaml
    /// </summary>
    public partial class InformWindow : Window
    {
        Ellipse ellipse;
        Rectangle rectangle;
        Thickness margin;
        bool isEllipse;
        public InformWindow(Ellipse el)
        {
            InitializeComponent();
            isEllipse = true;
            ellipse = el;
            widthText.Text = el.Width.ToString();
            heigthText.Text = el.Height.ToString();
            topText.Text = el.Margin.Top.ToString();
            leftText.Text = el.Margin.Left.ToString();
            SetComboColor(el.Fill);
        }
        public InformWindow(Rectangle re)
        {
            InitializeComponent();
            isEllipse = false;
            rectangle = re;
            widthText.Text = re.Width.ToString();
            heigthText.Text = re.Height.ToString();
            topText.Text = re.Margin.Top.ToString();
            leftText.Text = re.Margin.Left.ToString();
            SetComboColor(re.Fill);
        }
        private void SetComboColor(Brush oldColor)
        {
            if(oldColor == Brushes.Black) comboColor.SelectedIndex = 0;
            else if (oldColor == Brushes.Yellow) comboColor.SelectedIndex = 1;
            else if (oldColor == Brushes.Blue) comboColor.SelectedIndex = 2;
            else if (oldColor == Brushes.Red) comboColor.SelectedIndex = 3;
            else if (oldColor == Brushes.Pink) comboColor.SelectedIndex = 4;
            else if (oldColor == Brushes.Green) comboColor.SelectedIndex = 5;
        }
        private void SetColor()
        {
            Brush newColor;
            switch (comboColor.SelectedIndex)
            {
                case 0:
                    newColor = Brushes.Black;
                    break;
                case 1:
                    newColor = Brushes.Yellow;
                    break;
                case 2:
                    newColor = Brushes.Blue;
                    break;
                case 3:
                    newColor = Brushes.Red;
                    break;
                case 4:
                    newColor = Brushes.Pink;
                    break;
                case 5:
                    newColor = Brushes.Green;
                    break;
                default:
                    newColor = Brushes.White;   
                    break;
            }
            if (isEllipse) ellipse.Fill = newColor;
            else rectangle.Fill = newColor;
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            margin.Top = int.Parse(topText.Text);
            margin.Left = int.Parse(leftText.Text);
            if (isEllipse)
            {
                ellipse.Width = int.Parse(widthText.Text);
                ellipse.Height = int.Parse(heigthText.Text);
                ellipse.Margin = margin;
            }
            else
            {
                rectangle.Width = int.Parse(widthText.Text);
                rectangle.Height = int.Parse(heigthText.Text);
                rectangle.Margin = margin;
            }
            SetColor();
            this.Close();
        }
    }
}
