using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Human
    {
        // characteristics
        public String name;
        public int age;

        // actions
        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
}
