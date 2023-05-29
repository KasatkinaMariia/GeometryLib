using System;

namespace GeometryLibrary
{
    public class Triangle : IGeometricFigure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Стороны треугольника должны принимать положительное значение.");

            if (side1 + side2 <= side3
                || side2 + side3 <= side1
                || side1 + side3 <= side2)
                throw new ArgumentException("Треугольника с указанными сторонами не существует");
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public bool IsRightAngled(double accuracy = 0.000001)
        {
            if (Math.Abs(Side1 * Side1 - Side2 * Side2 - Side3 * Side3) < accuracy
                || Math.Abs(Side2 * Side2 - Side1 * Side1 - Side3 * Side3) < accuracy
                || Math.Abs(Side3 * Side3 - Side1 * Side1 - Side2 * Side2) < accuracy)
                return true;

            return false;
        }
    }
}
