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
using static System.Formats.Asn1.AsnWriter;

namespace geometry_drower;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void DrawLine(PointClass p1, PointClass p2)
    {
        Line line = new Line();
        line.Stroke = Brushes.Red;
        line.StrokeThickness = 3;
        line.X1 = p1.getX();
        line.Y1 = p1.getY();
        line.X2 = p2.getX();
        line.Y2 = p2.getY();
        Scene.Children.Add(line);


    }

    private void Button_triangle(object sender, RoutedEventArgs e)
    {

    }

    private void Button_rectangle(object sender, RoutedEventArgs e)
    {

    }

    private void Button_square(object sender, RoutedEventArgs e)
    {

    }

    private void Slider_Change_X(object sender, RoutedPropertyChangedEventArgs<double> e)
    {

    }

    private void Slider_Change_Y(object sender, RoutedPropertyChangedEventArgs<double> e)
    {

    }
}