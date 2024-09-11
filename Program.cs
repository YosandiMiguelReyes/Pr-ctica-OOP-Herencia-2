using System;

namespace ShapeApplication
{
    // Clase abstracta Shape
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateSurface();
    }

    // Clase Rectangle
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }

    // Clase Triangle
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }
    }

    // Clase Circle
    public class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius) { }

        public override double CalculateSurface()
        {
            return Math.PI * Width * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(4, 5),    // Rectángulo con ancho 4 y alto 5
                new Triangle(3, 6),     // Triángulo con base 3 y altura 6
                new Circle(4)           // Círculo con radio 4
            };

           
            double[] areas = new double[shapes.Length];
            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
            }

            // Mostrar las áreas calculadas
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Área de la forma {i + 1}: {areas[i]}");
            }
            Console.ReadLine();
        }
    }
}
