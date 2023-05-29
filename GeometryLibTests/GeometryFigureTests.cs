using GeometryLibrary;
using NUnit.Framework;
using System;
using FluentAssertions;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class GeometryFigureTests
    {
        [Test]
        public void CompileTime_TriangleArea()
        {
            IGeometricFigure obj = new Triangle(3, 4, 5);           
            obj.GetArea().Should().Be(6);
        }

        [Test]
        public void CompileTime_CircleArea()
        {
            IGeometricFigure obj = new Circle(3);
            obj.GetArea().Should().Be(9*Math.PI);
        }
    }
}
