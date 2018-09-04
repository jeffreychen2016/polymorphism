using System;
using System.Text;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape(100, 100);
            shape.Draw();

            Square square = new Square(200, 200);
            square.Draw();

            Circle circle = new Circle(300, 300);
            circle.Draw();

            StringBuilder builder = new StringBuilder();
            Console.WriteLine(builder.Append('-', 50));

            // Ploymorphism
            // upcasting: cast derived class type to base class type. In this case, Square and Circle to Shape.
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape(100, 100);
            shapes[1] = new Square(200, 200);
            shapes[2] = new Circle(300, 300);

            foreach (Shape sh in shapes)
            {
                sh.Draw();
                // downcasting: cast base class type to derived class type. In this case, Shape to Circle.
                //if (sh is Circle)
                //{
                //    Circle c = (Circle)sh;
                //    c.FillCircle();
                //}
                if (sh is Circle)
                {
                    ((Circle)sh).FillCircle();
                }
                else if (sh is Square)
                {
                    Console.WriteLine("Square does not have the fill method");
                }
            }     
        }
    }
}
