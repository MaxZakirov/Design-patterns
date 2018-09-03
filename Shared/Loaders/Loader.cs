using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Loaders
{
    public abstract class Loader : ILoader
    {
        public int Tick { get; protected set; }
        protected int loadTime;
        protected int loadBoofer;

        public Loader(int tick)
        {
            Tick = tick;
            loadTime = 5000;
            loadBoofer = 0;
        }

        public abstract void Load(int MilliSec = 0);

        public void ChangeTick(int Tick)
        {
            this.Tick = Tick;
        }

        public void Dispose()
        {
            Console.ResetColor();
            loadBoofer = 0;
        }
    }
}
