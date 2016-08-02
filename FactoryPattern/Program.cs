using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            FactoryCreator factoryCreator = new FactoryCreator();
            IBikeFactory factory = factoryCreator.GetBike("hero");
            string bikeType = factory.GetBike();
            Console.WriteLine(bikeType);

        }
    }
}
