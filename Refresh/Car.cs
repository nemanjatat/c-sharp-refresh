using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Car : Vehicle
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
