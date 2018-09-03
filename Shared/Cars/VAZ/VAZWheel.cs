using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars.VAZ
{
    public class VAZWheel : IWheel
    {
        public VAZWheel(int Diameter)
        {
            this.Diameter = Diameter;
        }

        public int Diameter { get; private set; }

        public string Company
        {
            get
            {
                return "VAZ";
            }
        }
    }
}
