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

        Console.WriteLine($"{Planets.Pluto} is planet #{(int)Planets.Pluto}.");
        Console.WriteLine($"{Planets.Mercury} is planet #{(int)Planets.Mercury}.");

        Console.ReadLine();
    }

    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
}