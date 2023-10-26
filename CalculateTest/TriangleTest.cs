using NUnit.Framework;
using System;
using Calculate;

namespace CalculateTest
{
    [TestFixture]
    public class TriangleTest
    {
        [TestCase(-1, 3, 2)]
        [TestCase(12, 1, -4)]
        [TestCase(1, 0, 5)]
        public void TriangleWrongParam(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c), "A triangle side can't be less or equal to zero");
        }

        [TestCase(1, 3, 2)]
        [TestCase(12, 1, 4)]
        [TestCase(1, 1, 5)]
        public void IsNotTriangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c), "Error input, is not a triangle");
        }

        [Test]
        public void TriangleZeroParam()
        {
            var triangle = new Triangle();

            Assert.AreEqual(triangle.SideA, 1);
            Assert.AreEqual(triangle.SideB, 1);
            Assert.AreEqual(triangle.SideC, 1);
        }

        [TestCase(3, 2, 4)]
        [TestCase(3, 4, 5)]
        [TestCase(15, 10, 6)]
        public void SquareRightProperty(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.AreEqual(triangle.SideA, a);
            Assert.AreEqual(triangle.SideB, b);
            Assert.AreEqual(triangle.SideC, c);
        }

        [TestCase(3, 6, 4)]
        [TestCase(8, 5, 5)]
        [TestCase(9, 4, 6)]
        public void TriangleArea(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var p = 0.5 * (a + b + c);
            var expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.AreEqual(triangle.Area(), expected);
        }

        [TestCase(3, 6, 4)]
        [TestCase(8, 5, 5)]
        [TestCase(9, 4, 6)]
        public void IsNotRightAngleTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.False(triangle.IsRightAngle);
        }

        [TestCase(3, 4, 5)]
        [TestCase(13, 5, 12)]
        [TestCase(8, 10, 6)]
        public void IsRightAngleTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsRightAngle);
        }
    }
}
