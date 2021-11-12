using System;

namespace Encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input side1: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Input side1: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"The rectangle area is {rectangle.Area}, perimetr is {rectangle.Perimetеr}");

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        private double _side1;
        private double _side2;
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        private double PerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }

        public double Perimetеr
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        private double AreaCalculator()
        {
            return _side1 * _side2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
    }

}
