using System;

namespace UpcastingAndDowncasting
{
    public class Circle : Shape
    {
        public Circle(int height, int width) : base(height, width)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle with {0} height,{1} width", Height, Width);
        }

        public void FillCircle()
        {
            Console.WriteLine("Filling CIRCLE with red color");
        }

    }
}
