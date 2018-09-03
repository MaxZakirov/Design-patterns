using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars
{
    public interface IWheel
    {
        int Diameter { get; }

        string Company { get; }
    }
}
