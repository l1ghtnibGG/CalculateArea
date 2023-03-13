using Calculate;
using NUnit.Framework;
using System;

namespace CalculateTest
{

    [TestFixture]
    public class SquareTest
    {
        [TestCase(-1)]
        [TestCase(-54)]
        [TestCase(0)]
        public void SquareWrongParam(double x)
        {
            Assert.Throws<ArgumentException>(() => new Square(x), "Less or equal to zero");
        }

        [Test]
        public void SquareZeroParam()
        {
            var square = new Square();

            Assert.AreEqual(square.Side, 1);
        }

        [TestCase(5)]
        [TestCase(1)]
        [TestCase(25)]
        public void SquareRightProperty(double x)
        {
            var square = new Square(x);

            Assert.AreEqual(square.Side, x);
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(8)]
        public void SquareArea(double x)
        {
            var square = new Square(x);

            var expected = x * x;

            Assert.AreEqual(square.Area(), expected);
        }

    }
}
