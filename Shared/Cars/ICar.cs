using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars
{
    public interface ICar
    {
        IEnumerable<IWheel> Wheels { get; }

        IEngine Engine { get; }

        int GetSpeed();

        void Start();

        void Finish();
    }
}
