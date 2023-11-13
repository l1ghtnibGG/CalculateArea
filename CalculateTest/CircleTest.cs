using NUnit.Framework;
using System;
using Calculate.Implementations;

namespace CalculateTest
{

    [TestFixture]
    public class CircleTest
    {
        [TestCase(-1)]
        [TestCase(-4)]
        [TestCase(0)]
        public void GetCircleWithWrongParameters(double x)
        {
            Assert.Throws<ArgumentException>(() => new Circle(x), "Radius can't be less or equal to zero");
        }

        [Test]
        public void GetCircleWithZeroParameters()
        {
            var circle = new Circle();

            Assert.AreEqual(circle.Radius, 1);
        }

        [TestCase(3)]
        [TestCase(1)]
        [TestCase(15)]
        public void GetSquareRightProperty(double x)
        {
            var circle = new Circle(x);

            Assert.AreEqual(circle.Radius, x);
        }

        [TestCase(47.8)]
        [TestCase(8.7)]
        [TestCase(12)]
        public void GetCircleAreaWithValidParameters(double x)
        {
            var circle = new Circle(x);

            var expected = Math.Pow(x, 2) * Math.PI;

            Assert.AreEqual(circle.GetArea(), expected);
        }
        
        [TestCase(2.5)]
        [TestCase(3.9)]
        [TestCase(12)]
        public void GetCirclePerimeterWithValidParameters(double x)
        {
            var circle = new Circle(x);

            var expected = 2 * Math.PI * circle.Radius;

            Assert.AreEqual(circle.GetPerimeter(), expected);
        }
    }
}
