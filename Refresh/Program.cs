using Refresh;

class Program
{
    static void Main(string[] args)
    {
        Car[] garage =
        {
            new Car("Mustang"),
            new Car("Corvette"),
            new Car("Lambo")
        };

        foreach(Car car in garage)
        {
            Console.WriteLine(car.model);
        }

        Console.ReadKey();
    }
}