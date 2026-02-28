using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Restaurant
    {
        String name;
        String address;
        double score;
        String phone_number;
        String website_link;

        public Restaurant(String name, String address, double score, String phone_number, String website_link)
        {
            this.name = name;
            this.address = address;
            this.score = score;
            this.phone_number = phone_number;
            this.website_link = website_link;
        }

        public void Info()
        {
            Console.WriteLine(name.ToUpper() + " INFO\n==================");
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Score: " + score + "/5");
            Console.WriteLine("Phone Number: " + phone_number);
            Console.WriteLine("Website Link: " + website_link);
        }
    }
}
