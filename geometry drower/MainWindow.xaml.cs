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

    Triangle triang;
    Square squ, reect;

    Random rnd = new Random();
    public MainWindow()
    {
        InitializeComponent();

    }

    public void createTriangle() // треугольник - тупо рандомные точки (чисто теоретически может получиться прямая)
    {
        PointClass point1 = new PointClass(rnd.Next(0,  (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point2 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point3 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));

        triang = new Triangle(point1, point2, point3);
    }
    public void createSqare() // квадрат - дандомим длину ребра и сторим все точки строго от первой
    {
        PointClass point1 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height)); // первая точка (девая верхняя)
        int linelenght = (rnd.Next(1, ((int)Scene.Height ) - Convert.ToInt32(point1.getX)) );
        PointClass point2 = new PointClass(Convert.ToInt32(point1.getX), Convert.ToInt32(point1.getY) + linelenght); // левая нижняя точка
        PointClass point3 = new PointClass(Convert.ToInt32(point1.getX) + linelenght, Convert.ToInt32(point1.getY)); // правая верхняя
        PointClass point4 = new PointClass(Convert.ToInt32(point1.getX)+linelenght , Convert.ToInt32(point1.getY) + linelenght); // спросить почему ругаеттся еси убрать конверт правая нижняя
    }
    public void createRectangle() // прямоугольник - рандомим длину и ширину, принцип похож на квадрат
    {
        PointClass point1 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height)); // первая точка (девая верхняя)
        int xlenght = (rnd.Next(1, ((int)Scene.Width) - Convert.ToInt32(point1.getX)));
        int yLenght = (rnd.Next(1, ((int)Scene.Height) - Convert.ToInt32(point1.getX)));
        PointClass point2 = new PointClass(Convert.ToInt32(point1.getX), Convert.ToInt32(point1.getY) + yLenght); // левая нижняя точка
        PointClass point3 = new PointClass(Convert.ToInt32(point1.getX) + xlenght, Convert.ToInt32(point1.getY)); // правая верхняя
        PointClass point4 = new PointClass(Convert.ToInt32(point1.getX) + xlenght, Convert.ToInt32(point1.getY) + yLenght); //  правая нижняя
    }

    //проблема всей этой штуки что её невозможно проверить пока Дима не сделает визуалку
}