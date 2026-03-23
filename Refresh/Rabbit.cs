using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit is running away!");
        }
    }
}
