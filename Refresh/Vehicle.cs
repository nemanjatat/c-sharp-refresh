using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    // We don't want users to be able to create a generic Vehicle object...
    // ... as it's missing the wheels property
    // so we'll add the abstract modifier to the class so that it can't be used
    // with that, the users can't do:
    // Vehicle vehicle = new Vehicle();
    abstract internal class Vehicle
    {
        public int speed;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
}
