using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new DOTShape(ConsoleColor.Red);
            IShape clone = (IShape)shape1.Clone();
            clone.Color = ConsoleColor.Green;
            shape1.Print();
            clone.Print();
        }
    }
}
