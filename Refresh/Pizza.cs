using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public void CustomerOrderInfo()
        {
            Console.WriteLine("Customer order:");

            if (bread != null)
            {
                Console.Write($"| {bread} |");
            }

            if (sauce != null)
            {
                Console.Write($"| {sauce} |");
            }

            if (cheese != null)
            {
                Console.Write($"| {cheese} |");
            }

            if (topping != null)
            {
                Console.Write($"| {topping} |");
            }

            Console.WriteLine();
        }
    }
}
