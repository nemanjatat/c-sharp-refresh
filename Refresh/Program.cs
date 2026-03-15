using Refresh;

class Program
{
    static void Main(string[] args)
    {
        Flower flower = new Flower("Lilacs", "white");
        Flower flower_copy = Copy(flower);

        Console.WriteLine($"Flower name: {flower_copy.name}\nFlower color: {flower_copy.color}");

        Console.ReadKey();
    }

    public static Flower Copy(Flower flower)
    {
        return new Flower(flower.name, flower.color);
    }
}