using Refresh;

class Program
{
    static void Main(string[] args)
    {
        // interface = defines a "contract" that all the class inheriting from should follow

        //             An interface declares "what a class should have"
        //             An inheriting class defines "how it should do it"

        //             Benefit = security + multiple inheritence + "plug-and-play"

        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();

        Console.ReadLine();
    }
}