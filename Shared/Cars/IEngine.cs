using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars
{
    public interface IEngine
    {
        bool IsWorking { get; }

        int Power { get; }

        void Finsih();

        void Start(string key);
    }
}
