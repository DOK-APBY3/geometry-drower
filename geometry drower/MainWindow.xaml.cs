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

namespace geometry_drower;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    Random rnd = new Random();
    public MainWindow()
    {
        InitializeComponent();

    }

    public void createTriangle()
    {
        PointClass point1 = new PointClass(rnd.Next(0,  (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point2 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point3 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
    }
    public void createSqare()
    {
        PointClass point1 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        int linelenght = (rnd.Next(0, ((int)Scene.Height)  - Convert.ToInt32(point1.getX))); 
        PointClass point2 = new PointClass(Convert.ToInt32(point1.getX) , Convert.ToInt32(point1.getY)); // спросить почему ругаеттся еси убрать конверт
    }
    public void createRectangle()
    {
        PointClass point1 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point2 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point3 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
    }
}