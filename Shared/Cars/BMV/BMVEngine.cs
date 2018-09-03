using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars.BMV
{
    public class BMVEngine : IEngine
    {
        private const string internalKey = "BMV";

        public BMVEngine(int Power)
        {
            this.Power = Power;
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
