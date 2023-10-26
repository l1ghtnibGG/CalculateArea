using System;


namespace Calculate
{
    public abstract class Shape
    {
        private readonly Lazy<double> _area;
        
        public double Square => _area.Value;

        protected Shape() => _area = new Lazy<double>(Area);
        
        
        /// <summary>
        /// Calculate a shape's area
        /// </summary>
        public abstract double Area();
    }
}


