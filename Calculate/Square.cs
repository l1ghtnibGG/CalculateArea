using System;

namespace Calculate
{
    public class Square : Shape
    {
        private double _side;

        public Square()
        {
            _side = 1;
        }

        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Less or equal to zero");
            }

            _side = side;
        }

        public double Side 
        { 
            get { return _side; }
            set { _side = value; }
        }

        public override double Area() => _side * _side;
    }
}