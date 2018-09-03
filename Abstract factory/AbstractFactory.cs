using Shared.Cars;
using System.Collections.Generic;

namespace Abstract_factory
{
    public interface IAbstractFactory
    {
        ICar CreateCar();

        IEngine CreateEngine();

        IEnumerable<IWheel> CreateWheelsPackage();
    }
}
