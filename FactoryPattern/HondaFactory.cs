using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class HondaFactory:IBikeFactory
    {
        public string GetBike()
        {
            return "Honda Bike";
        }
    }
}
