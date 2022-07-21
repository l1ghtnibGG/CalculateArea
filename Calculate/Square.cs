using System;

namespace Calculate
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area() => Side * Side;
    }
}