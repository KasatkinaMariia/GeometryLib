using GeometryLibrary;
using NUnit.Framework;
using System;
using FluentAssertions;


namespace GeometryLibraryTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void NegativeSide_Throw()
        {
            try
            {
                var obj = new Triangle(-5, 10, 78);
            }
            catch (ArgumentException e)
            {
                e.Message.Should().Be("Стороны треугольника должны принимать положительное значение.");
                return;
            }

            Assert.Fail();
        }

        [Test]
        public void ZeroSide_Throw()
        {
            try
            {
                var obj = new Triangle(5, 10, 0);
            }
            catch (ArgumentException e)
            {
                e.Message.Should().Be("Стороны треугольника должны принимать положительное значение.");
                return;
            }

            Assert.Fail();
        }

        [Test]
        public void TriangleDoesntExist()
        {
            try
            {
                var obj = new Triangle(5, 10, 78);
            }
            catch (ArgumentException e)
            {
                e.Message.Should().Be("Треугольника с указанными сторонами не существует");
                return;
            }

            Assert.Fail();
        }

        [Test]
        public void GetArea()
        {
            var obj = new Triangle(5, 4, 3);
            obj.GetArea().Should().Be(6);
        }

        [Test]
        public void IsRightAngled_true()
        {
            var obj = new Triangle(5, 4, 3);
            obj.IsRightAngled().Should().BeTrue();
        }

        [Test]
        public void IsRightAngled_false()
        {
            var obj = new Triangle(15, 14, 13);
            obj.IsRightAngled().Should().BeFalse();
        }


        [Test]
        public void IsRightAngledWithDoubleValues_true()
        {
            var obj = new Triangle(25.78, 12.7, 28.738448114);
            obj.IsRightAngled(0.00000001).Should().BeTrue();
        }
    }
}
