using Refresh;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // getters & setters = add security to fields by encapsulation
        //                     They're accessors found within properties

        // properties = combine aspects of both fields and methods (share name with a field)
        // get accessor = used to return the property value
        // set accessor = used to assign a new value
        // value keyword = defines the value being assigned by the set (parameter)

        DollarStore ds = new DollarStore("pizza cutter", 25);

        Console.WriteLine(ds);

        ds.Price = 100;

        Console.WriteLine(ds);

        Console.ReadLine();
    }
}