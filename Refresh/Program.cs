using Refresh;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // enums = special "class" that contains a set of named integer constants.
        //         Use enums when you have values that you know will not change,
        //         To get the integer value from an item, you must explicitly convert to an int

        //         name = integer

        Console.WriteLine($"{Planets.Pluto} is a planet.");

        Console.ReadLine();
    }

    enum Planets
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }
}