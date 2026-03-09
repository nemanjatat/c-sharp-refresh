using Refresh;

class Program
{
    static void Main(string[] args)
    {
        // inheritance = 1 or more child classes receiving fields, methods, etc. from a common parent

        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Console.WriteLine(car.speed);
        Console.WriteLine(car.wheels);
        car.Go();

        Console.WriteLine(bicycle.speed);
        Console.WriteLine(bicycle.wheels);
        bicycle.Go();

        Console.WriteLine(boat.speed);
        Console.WriteLine(boat.wheels);
        boat.Go();

        Console.ReadKey();
    }
}