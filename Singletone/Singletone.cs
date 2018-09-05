using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class Singletone
    {
        private static readonly Singletone _instance;

        public int X { get; set; }

        public int Y { get; set; }

        public int Sum()
        {
            return X + Y;
        }

        public static Singletone Getinstance()
        {
            return _instance;
        }

        private Singletone()
        {
            this.X = 5;
            this.Y = 10;
        }

        static Singletone()
        {
            _instance = new Singletone();
        }
    }
}
