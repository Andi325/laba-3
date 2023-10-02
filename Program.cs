using System;

class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point A, Point B, Point C)
    {
        points = new Point[] { A, B, C };
    }

    public Figure(Point A, Point B, Point C, Point D)
    {
        points = new Point[] { A, B, C, D };
    }

    public Figure(Point A, Point B, Point C, Point D, Point E)
    {
        points = new Point[] { A, B, C, D, E };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = (i == points.Length - 1) ? points[0] : points[i + 1];
            perimeter += GetSideLength(currentPoint, nextPoint);
        }

        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        // Завдання 1
        Console.WriteLine("Завдання 1:");
        Console.Write("Введіть довжину першої сторони: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть довжину другої сторони: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);
        Console.WriteLine($"Площа: {rectangle.Area}");
        Console.WriteLine($"Периметр: {rectangle.Perimeter}");
        Console.WriteLine();

        // Завдання 2
        Console.WriteLine("Завдання 2:");
        Point A = new Point(0, 0, "A");
        Point B = new Point(4, 0, "B");
        Point C = new Point(4, 3, "C");

        Figure figure1 = new Figure(A, B, C);
        figure1.CalculatePerimeter();
        
        Point D = new Point(0, 3, "D");
        Figure figure2 = new Figure(A, B, C, D);
        figure2.CalculatePerimeter();

        Point E = new Point(2, 5, "E");
        Figure figure3 = new Figure(A, B, C, D, E);
        figure3.CalculatePerimeter();
    }
}
