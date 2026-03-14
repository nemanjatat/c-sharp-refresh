using Refresh;

class Program
{
    static void Main(string[] args)
    {
        Flower flower = new Flower("Lilacs", "white");

        ChangeColor(flower, "purple");

        Console.WriteLine($"Flower name: {flower.name}\nFlower color: {flower.color}");

        Console.ReadKey();
    }

    public static void ChangeColor(Flower flower, String color)
    {
        flower.color = color;
    }
}