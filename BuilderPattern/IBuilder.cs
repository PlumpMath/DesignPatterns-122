using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void FirstName();
        void LastName();
        void FullName();
        void Address();
        void Contact();
    }
}
