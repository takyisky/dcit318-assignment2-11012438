using System;

namespace AbstractClassesAndMethods
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle implements GetArea = πr²
    class Circle : Shape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    // Rectangle implements GetArea = l*w
    class Rectangle : Shape
    {
        private readonly double _length;
        private readonly double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sample values (you can change)
            Circle circle = new Circle(5);          // radius = 5
            Rectangle rectangle = new Rectangle(4, 7); // length = 4, width = 7

            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
        }
    }
}
