using System.Collections.Generic;
using Shared.Cars;
using Shared.Cars.BMV;

namespace Abstract_factory
{
    public class BMVFactory : IAbstractFactory
    {
        public ICar CreateCar()
        {
            return new BMVCar(this.CreateWheelsPackage(),this.CreateEngine());
        }

        public IEngine CreateEngine()
        {
            return new BMVEngine(1500);
        }

        public IEnumerable<IWheel> CreateWheelsPackage()
        {
            List<BMVWheel> wheels = new List<BMVWheel>();
            for (int i = 0; i < 4; i++)
            {
                wheels.Add(new BMVWheel(50));
            }
            return wheels;
        }
    }
}
