using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars.VAZ
{
    public class VAZEngine : IEngine
    {
        private const string internalKey = "VAZ";

        public VAZEngine(int Power)
        {
            this.Power = Power/2;
        }

        public bool IsWorking { get; private set; }

        public int Power { get; set; }

        public void Finsih()
        {
            IsWorking = false;
        }

        public void Start(string key)
        {
            if (internalKey == key)
                IsWorking = true;
            else
                Console.WriteLine("Key is invalid.");
        }
    }
}
