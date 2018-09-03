using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars.BMV
{
    public class BMVWheel : IWheel
    {
        public BMVWheel(int Diameter)
        {
            this.Diameter = Diameter;
        }

        public int Diameter { get; private set; }

        public string Company
        {
            get
            {
                return "BMV";
            }
        }
    }
}
