using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Car
    {
        String model;
        public static int numberOfCars = 0;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has started!");
        }
    }
}
