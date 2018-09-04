using System;

namespace UpcastingAndDowncasting
{
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int PostionX { get; set; }
        public int PostionY { get; set; }

        public Shape(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a SHAPE with {0} height,{1} width", Height,Width );
        }
    }
}
