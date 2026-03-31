using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Location
    {
        public String Name { get; set; }
        public String Coordinates { get; set; }

        public Location(String name, String coordinates)
        {
            this.Name = name;
            this.Coordinates = coordinates;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nCoordinates: {Coordinates}";
        }
    }
}
