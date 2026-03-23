using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
    }
}
