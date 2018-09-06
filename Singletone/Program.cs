using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletone s = Singletone.Getinstance();
            Console.WriteLine(s.Sum());
            Singletone s1 = Singletone.Getinstance();
            s1.X = 10;
            Console.WriteLine(s.Sum());
        }
    }
}
