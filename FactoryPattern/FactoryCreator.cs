using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FactoryCreator
    {
        public IBikeFactory GetBike(string bikeType)
        {
            switch (bikeType)
            {

                case "hero":
                    return new HeroFactory();

                case "honda":
                    return new HondaFactory();
                case "yamaha":
                    return new YamahaFactory();
                default:
                    string message = string.Format("This {0} bike type not supported", bikeType);
                    throw new NotSupportedException(message);
            }
        }
    }
}
