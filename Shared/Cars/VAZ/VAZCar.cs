using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cars.VAZ
{
    public class VAZCar : ICar
    {

        public readonly string key = "VAZ";

        public VAZCar(
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
                return Engine.Power / 2;
            }
            else
            {
                throw new Exception();
            }
        }

        public void Start()
        {
            int rnd = new Random().Next(5);
            if (rnd == 3)
                throw new Exception("Engine is broken");
            Engine.Start(key);
        }

        public void Finish()
        {
            Engine.Finsih();
        }
    }
}
