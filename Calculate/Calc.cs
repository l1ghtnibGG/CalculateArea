using System;


namespace Calculate
{
    public abstract class Shape
    {
        public static void Display()
        {
            while (true)
            {
                Console.WriteLine("Input type of figure (1 - Square, 2 - Triangle, 3 - Circle, 0 - Exit):");
                int y;

                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Error input. Try again");
                }

                double x;
                switch (y)
                {
                    case 1:
                        Console.WriteLine("Input value of side:");

                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("Error input. Try again");
                        }

                        var square = new Square
                        {
                            Side = x
                        };

                        Console.WriteLine($"Square of square is {square.Area()}");
                        break;

                    case 2:
                        Console.WriteLine("Input value of side A:");
                        double sideA;

                        while (!double.TryParse(Console.ReadLine(), out sideA))
                        {
                            Console.WriteLine("Error input. Try again");
                        }

                        Console.WriteLine("Input value of side B:");
                        double sideB;

                        while (!double.TryParse(Console.ReadLine(), out sideB))
                        {
                            Console.WriteLine("Error input. Try again");
                        }

                        Console.WriteLine("Input value of side C:");
                        double sideC;

                        while (!double.TryParse(Console.ReadLine(), out sideC))
                        {
                            Console.WriteLine("Error input. Try again");
                        }

                        var triangle = new Triangle()
                        {
                            A = sideA,
                            B = sideB,
                            C = sideC
                        };

                        Console.WriteLine($"Square of triangle is {triangle.Area()}");

                        if (triangle.IsRectangle())
                            Console.WriteLine("It's right-angle triangle");

                        break;

                    case 3:
                        Console.WriteLine("Input value of side:");
                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("Error input. Try again");
                        }

                        var circle = new Circle()
                        {
                            R = x
                        };

                        Console.WriteLine($"Square of circle is {circle.Area()}");
                        break;

                    case 0:
                        return;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
        }

        public abstract double Area();
    }
}


