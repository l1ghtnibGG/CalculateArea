using Calculate;
using NUnit.Framework;
using System;

namespace CalculateTest
{

    [TestFixture]
    public class CircleTest
    {
        [TestCase(-1)]
        [TestCase(-4)]
        [TestCase(0)]
        public void CircleWrongParam(double x)
        {
            Assert.Throws<ArgumentException>(() => new Circle(x), "Less or equal to zero");
        }

        [Test]
        public void CircleZeroParam()
        {
            var circle = new Circle();

            Assert.AreEqual(circle.R, 1);
        }

        [TestCase(3)]
        [TestCase(1)]
        [TestCase(15)]
        public void SquareRightProperty(double x)
        {
            var circle = new Circle(x);

            Assert.AreEqual(circle.R, x);
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(12)]
        public void CircleArea(double x)
        {
            var circle = new Circle(x);

            var expected = x * x * Math.PI;

            Assert.AreEqual(circle.Area(), expected);
        }
    }
}
