using System;

namespace UpcastingAndDowncasting
{
    public class Square : Shape
    {
        public Square(int height, int width) : base(height, width)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Square with {0} height,{1} width", Height, Width);
        }

    }
}
