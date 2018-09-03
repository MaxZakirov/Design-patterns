using Shared.Cars;
using Shared.Cars.VAZ;
using System.Collections.Generic;

namespace Abstract_factory
{
    public class VAZFactory : IAbstractFactory
    {
        public ICar CreateCar()
        {
            return new VAZCar(this.CreateWheelsPackage(), this.CreateEngine());
        }

        public IEngine CreateEngine()
        {
            return new VAZEngine(1000);
        }

        public IEnumerable<IWheel> CreateWheelsPackage()
        {
            List<VAZWheel> wheels = new List<VAZWheel>();
            for (int i = 0; i < 4; i++)
            {
                wheels.Add(new VAZWheel(40));
            }
            return wheels;
        }
    }
}
