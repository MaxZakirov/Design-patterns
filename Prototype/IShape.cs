using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IShape : ICloneable
    {
        void Print();

        ConsoleColor Color { get; set; }
    }
}
