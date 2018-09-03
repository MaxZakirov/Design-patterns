using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory1 = new BMVFactory();
            IAbstractFactory factory2 = new VAZFactory();
            var bmv = factory1.CreateCar();
            var vaz = factory2.CreateCar();
            bmv.Start();
            Console.WriteLine(bmv.GetSpeed());
            bmv.Finish();
            while(true)
            {
                try
                {
                    vaz.Start();
                    Console.WriteLine(vaz.GetSpeed());
                    vaz.Finish();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
    }
}
