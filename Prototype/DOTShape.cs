using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DOTShape : IShape
    {
        private readonly int width;
        private readonly int height;

        public DOTShape(ConsoleColor color)
        {
            Color = color;
            Random rnd = new Random();
            width = rnd.Next(10);
            height = rnd.Next(10);
        }

        private DOTShape(DOTShape shape)
        {
            width = shape.width;
            height = shape.height;
            Color = shape.Color;
        }

        public ConsoleColor Color { get; set ; }

        public object Clone()
        {
            return new DOTShape(this);
        }

        public void Print()
        {
            Console.ForegroundColor = Color;
            for(int i =0;i<height;i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
