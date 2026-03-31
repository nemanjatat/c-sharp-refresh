using Refresh;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Auto-Implemented properties = shortcut when no additional logic is required in the property
        //                               you do not have to define a field for a property
        //                               you only have to write get; and/or set; inside a property

        Location location = new Location("Gostilnica Štrudl", 
            "46.272743900741176, 13.952891840480277");

        Console.WriteLine(location);

        Console.ReadLine();
    }
}