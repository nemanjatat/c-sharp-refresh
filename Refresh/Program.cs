using Refresh;

class Program
{
    static void Main(string[] args)
    {
        Car[] garage = new Car[3];

        Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");
        Car car3 = new Car("Lambo");

        garage[0] = car1;
        garage[1] = car2;
        garage[2] = car3;

        foreach(Car car in garage)
        {
            Console.WriteLine(car.model);
        }

        Console.ReadKey();
    }
}