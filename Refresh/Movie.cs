using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class Movie
    {
        String name;

        public Movie(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
