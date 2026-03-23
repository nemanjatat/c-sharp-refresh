using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish is swimming away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }
}
