using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class DollarStore
    {
        String item;
        double price;

        public DollarStore(String item, double price)
        {
            this.item = item;
            this.price = 1;
        }

        public double Price
        {
            get { return price; } // read
            set                   // write
            {
                if (value > 1 || value < 1)
                {
                    price = 1;
                }
                else
                {
                    price = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Item name: {item}\nPrice: {price}";
        }
    }
}
