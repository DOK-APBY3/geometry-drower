using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;

namespace geometry_drower;

public partial class MainWindow : Window
{

    Triangle triang;
    Square squ, rect;
    GeometryPrimitive currentFigure;
    List<PointClass> allPoints = new List<PointClass>();

    Random rnd = new Random();
    public MainWindow()
    {
        InitializeComponent();
    }
    public void DrawLine(PointClass p1, PointClass p2)
    {
        //создание линии
        Line line = new Line();
        //свойства линии
        line.Stroke = Brushes.Red;
        line.StrokeThickness = 3;
        //координаты линии
        line.X1 = p1.getX();
        line.Y1 = p1.getY();
        line.X2 = p2.getX();
        line.Y2 = p2.getY();
        //создание линии в сцене
        Scene.Children.Add(line);


    }

    private void Button_triangle(object sender, RoutedEventArgs e)
    {
        createTriangle();
    }

    private void Button_rectangle(object sender, RoutedEventArgs e)
    {
        createRectangle();
    }

    private void Button_square(object sender, RoutedEventArgs e)
    {
        createSqare();
    }

    private void Slider_Change_X(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        int newVal = Convert.ToInt32(e.NewValue);
        if (currentFigure != null)
        {
            int DeltaX = newVal - currentFigure.getP1().getX();
            currentFigure.addX(DeltaX);
        }
    }

    private void Slider_Change_Y(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        int newVal = Convert.ToInt32(e.NewValue);
        if (currentFigure != null)
        {
            int DeltaY = newVal - currentFigure.getP1().getY();
            currentFigure.addY(DeltaY);
        }

    }


    public void createTriangle() // треугольник - тупо рандомные точки (чисто теоретически может получиться прямая)
    {
        PointClass point1 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point2 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        PointClass point3 = new PointClass(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));

        triang = new Triangle(point1, point2, point3);
        triang.MooveEvent += moover;

        currentFigure = triang;

        List<PointClass> allPointsOffTri = currentFigure.GetAllPoints();

        int maxX = allPointsOffTri.Max(point => point.getX());
        int maxY = allPointsOffTri.Max(point => point.getY());
        int minX = allPointsOffTri.Min(point => point.getX());
        int minY = allPointsOffTri.Min(point => point.getY());

        SliderX.Value = minX;
        SliderY.Value = minY;

        SliderX.Maximum = Scene.Width - maxX;
        SliderY.Maximum = Scene.Height - maxY;

    }

    public void createSqare() // квадрат - дандомим длину ребра и сторим все точки строго от первой
    {

        PointClass point1 = new PointClass(rnd.Next(2, (int)Scene.Width), rnd.Next(0, (int)Scene.Height)); // первая точка (девая верхняя)
        int linelenght = (rnd.Next(1, ((int)Scene.Height) - point1.getY()));
        PointClass point2 = new PointClass(point1.getX(), point1.getY() + linelenght); // левая нижняя точка
        PointClass point3 = new PointClass(point1.getX() + linelenght, point1.getY() + linelenght); // правая нижняя
        PointClass point4 = new PointClass(point1.getX() + linelenght, point1.getY()); // правая верхняя

        squ = new Square(point1, point2, point3, point4);
        squ.MooveEvent += moover;

        currentFigure = squ;

        SLiderSetupper(currentFigure);

    }


    public void createRectangle() // прямоугольник - рандомим длину и ширину, принцип похож на квадрат
    {
        PointClass point1 = new PointClass(rnd.Next(2, (int)Scene.Width - 2), rnd.Next(0, (int)Scene.Height)); // первая точка (девая верхняя)
        int xlenght = (rnd.Next(1, ((int)Scene.Width) - point1.getX()));
        int yLenght = (rnd.Next(1, ((int)Scene.Height) - point1.getY()));
        PointClass point2 = new PointClass(point1.getX(), point1.getY() + yLenght); // левая нижняя точка
        PointClass point3 = new PointClass(point1.getX() + xlenght, point1.getY() + yLenght); //  правая нижняя
        PointClass point4 = new PointClass(point1.getX() + xlenght, point1.getY()); // правая верхняя

        rect = new Square(point1, point2, point3, point4);
        rect.MooveEvent += moover;

        currentFigure = rect;
        SLiderSetupper(currentFigure);
    }

    void moover()
    {
        ClearScene();
        allPoints.Clear();
        allPoints = currentFigure.GetAllPoints();
        int lastI = 0;

        for (int i = 1; i < allPoints.Count; i++)
        {
            DrawLine(allPoints[i - 1], allPoints[i]);
            lastI = i;
        }
        DrawLine(allPoints[0], allPoints[lastI]);

    }

    public void SLiderSetupper(GeometryPrimitive figure)
    {
        List<PointClass> allPointsOffTri = figure.GetAllPoints();

        int maxX = allPointsOffTri[2].getX();
        int maxY = allPointsOffTri[2].getY();
        int minX = allPointsOffTri[0].getX();
        int minY = allPointsOffTri[0].getY();

        SliderX.Value = minX;
        SliderY.Value = minY;

        SliderX.Maximum = Scene.Width - maxX;
        SliderY.Maximum = Scene.Height - maxY;
    }

    public void ClearScene()
    {
        Scene.Children.Clear();
    }
}

