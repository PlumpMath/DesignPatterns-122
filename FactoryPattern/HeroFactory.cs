using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class HeroFactory:IBikeFactory
    {
        public string GetBike()
        {
            return "Hero Bike";
        }
    }
}
