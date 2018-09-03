using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared.Loaders
{
    public class RedDotLoader : Loader
    {
        public RedDotLoader(int Tick)
            : base(Tick) { }

        public override void Load(int MilliSec)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            int timeToWait = loadTime == 0 ? loadTime : MilliSec;

            while (loadBoofer < loadTime)
            {
                Console.WriteLine(". . ... . .");
                Thread.Sleep(Tick);
                loadBoofer += Tick;
            }
        }
    }
}
