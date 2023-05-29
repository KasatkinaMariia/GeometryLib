using GeometryLibrary;
using NUnit.Framework;
using System;
using FluentAssertions;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void NegativeRadius_Throw()
        {
            try
            {
                var obj = new Circle(-5);
            }
            catch (ArgumentException e)
            {
                e.Message.Should().Be("Радиус не может принимать отрицательное значение.");
                return;
            }

            Assert.Fail();
        }

        [Test]
        public void GetAreaWithZeroRadius()
        {
            var obj = new Circle(0);
            obj.GetArea().Should().Be(0);
        }

        [Test]
        public void GetAreaWithPositiveRadius()
        {
            var obj = new Circle(5);
            obj.GetArea().Should().Be(25 * Math.PI);
        }

        [Test]
        public void GetPerimeterWithZeroRadius()
        {
            var obj = new Circle(0);
            obj.GetPerimeter().Should().Be(0);
        }

        [Test]
        public void GetPerimeterWithPositiveRadius()
        {
            var obj = new Circle(7);
            obj.GetPerimeter().Should().Be(14 * Math.PI);
        }
    }
}