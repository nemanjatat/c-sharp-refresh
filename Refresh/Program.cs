using Refresh;

class Program
{
    static void Main(string[] args)
    {
        // constructor = A special method in a class
        //               Same name as the class name
        //               Can be used to assign arguments to fields when creating an object

        Restaurant restaurant1 = new Restaurant("Boss", "Matije Korvina 7", 4.5, "+381 24 551111", "www.bosscaffe.com");
        Restaurant restaurant2 = new Restaurant("DENIS Gastro Temple", "Brace Radic 24", 3.8, "+381 24 551155", "denisgastrotemple.rs");

        restaurant1.Info();
        Console.WriteLine();
        restaurant2.Info();

        Console.ReadKey();
    }
}