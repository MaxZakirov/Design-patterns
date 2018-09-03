using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Loaders
{
    public interface ILoader : IDisposable
    {
        int Tick { get; }

        void ChangeTick(int Tick);

        void Load(int MilliSec);
    }
}
