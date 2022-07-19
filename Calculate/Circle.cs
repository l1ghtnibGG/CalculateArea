using System;

namespace Calculate
{
    public class Circle : Shape
    {
        public double R { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(R, R);
        }
    }
}