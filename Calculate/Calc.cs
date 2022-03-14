using System;

namespace Calculate
{
    public  class Shape
    {
        public virtual double Area()
        {
            return 0;
        }

        public void Display()
        {
            bool a = true;
            while (a)
            {

                Console.WriteLine("Input type of figure (1 - Square, 2 - Triangle, 3 - Circle, 0 - Exit):");
                short y = Convert.ToInt16(Console.ReadLine());

                switch (y)
                {
                    case 1:
                        Console.WriteLine("Input value of side:");
                        double x = Convert.ToDouble(Console.ReadLine());

                        Square square = new Square
                        {
                            Side = x
                        };
                        x = square.Area();
                        Console.WriteLine($"Square of square is {x}");
                        break;
                    case 2:
                        Console.WriteLine("Input value of side A:");
                        double sideA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input value of side B:");
                        double sideB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input value of side C:");
                        double sideC = Convert.ToDouble(Console.ReadLine());

                        Triangle triangle = new Triangle()
                        {
                            A = sideA,
                            B = sideB,
                            C = sideC
                        };
                        x = triangle.Area();
                        Console.WriteLine($"Square of triangle is {x}");
                        if (triangle.isRectangle())
                        {
                            Console.WriteLine("It's right-angle triangle");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Input value of side:");
                        x = Convert.ToDouble(Console.ReadLine());

                        Circle circle = new Circle()
                        {
                            R = x
                        };
                        x = circle.Area();
                        Console.WriteLine($"Square of circle is {x}");
                        break;
                    case 0:
                        a = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }

        }

    }

    public class Square : Shape
    {
        private double side;

        public double Side
        {
            get => side;
            set => side = value;
        }
        public override double Area()
        {
            return side * side;
        }
    }

    public class Triangle : Shape
    {
        private double a, b, c;

        public double A
        {
            get => a;
            set => a = value;
        }

        public double B
        {
            get => b;
            set => b = value;
        }
        public double C {
            get => c;
            set => c = value;
        }

        public bool isRectangle()
        {
            bool max = c * c == (a * a) + (b * b) ? true : a * a == (c * c) + (b * b) ? true : b * b == (c * c) + (a * a) ? true : false;

            if (max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double Area()
        {
            double p = 0.5 * (a + b + c);
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }

    public class Circle : Shape
    {
        private double r;
        public double R 
        {
            get => r;
            set => r = value;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(r, r);
        }
    }

}


