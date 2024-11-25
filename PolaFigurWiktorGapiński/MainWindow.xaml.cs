using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PolaFigurWiktorGapiński
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateSquareArea(object sender, RoutedEventArgs e)
        {
            try
            {
                double side = double.Parse(sideSquareTextBox.Text);
                double area = side * side;
                squareAreaTextBox.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawną wartość dla boku kwadratu.");
            }
        }

        private void CalculateSquarePerimeter(object sender, RoutedEventArgs e)
        {
            try
            {
                double side = double.Parse(sideSquareTextBox.Text);
                double perimeter = 4 * side;
                squarePerimeterTextBox.Text = perimeter.ToString();
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawną wartość dla boku kwadratu.");
            }
        }

        private void CalculateRectangleArea(object sender, RoutedEventArgs e)
        {
            try
            {
                double length = double.Parse(sideRectLengthTextBox.Text);
                double width = double.Parse(sideRectWidthTextBox.Text);
                double area = length * width;
                rectangleAreaTextBox.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne wartości dla boków prostokąta.");
            }
        }

        private void CalculateRectanglePerimeter(object sender, RoutedEventArgs e)
        {
            try
            {
                double length = double.Parse(sideRectLengthTextBox.Text);
                double width = double.Parse(sideRectWidthTextBox.Text);
                double perimeter = 2 * (length + width);
                rectanglePerimeterTextBox.Text = perimeter.ToString();
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne wartości dla boków prostokąta.");
            }
        }

        private void CalculateCircleArea(object sender, RoutedEventArgs e)
        {
            try
            {
                double radius = double.Parse(radiusCircleTextBox.Text);
                double area = Math.PI * radius * radius;
                circleAreaTextBox.Text = area.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawną wartość dla promienia okręgu.");
            }
        }

        private void CalculateCirclePerimeter(object sender, RoutedEventArgs e)
        {
            try
            {
                double radius = double.Parse(radiusCircleTextBox.Text);
                double perimeter = 2 * Math.PI * radius;
                circlePerimeterTextBox.Text = perimeter.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawną wartość dla promienia okręgu.");
            }
        }
    }
}