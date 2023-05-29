using System;

namespace GeometryLibrary
{
    public class Circle : IGeometricFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может принимать отрицательное значение.");
            Radius = radius;
        }

        public double GetArea() => Math.PI * Radius * Radius;

        public double GetPerimeter() => 2 * Math.PI * Radius;

    }
}
