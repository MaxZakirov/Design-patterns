using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars.BMV
{
    public class BMVCar : ICar
    {
        private const string key = "BMV";

        public BMVCar(
            IEnumerable<IWheel> Wheels,
            IEngine Engine)
        {
            this.Engine = Engine;
            List<IWheel> internalWheels = new List<IWheel>();
            foreach (var wheel in Wheels)
            {
                if (wheel.Company != key)
                    throw new Exception("wheels do not fit");
                internalWheels.Add(wheel);
            }
            this.Wheels = internalWheels;
        }

        public IEnumerable<IWheel> Wheels { get; private set; }

        public IEngine Engine { get; private set; }

        public int GetSpeed()
        {
            if (Engine.IsWorking)
            {
                return Convert.ToInt32(Math.Pow(Engine.Power, 2));
            }
            else
            {
                Console.WriteLine("Please, turn on the engine. ");
                return 0;
            }
        }

        public void Start()
        {
            Engine.Start(key);
        }

        public void Finish()
        {
            Engine.Finsih();
        }
    }
}
