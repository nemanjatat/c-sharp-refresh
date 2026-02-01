// method overloading = methods share same name, but different parameters
//                      name + parameters = signature
//                      methods must have a unique signature

class Program
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number 2: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number 3: ");
        double z = Convert.ToDouble(Console.ReadLine());

        double result = Multiply(x, y);
        Console.WriteLine($"{x} * {y} = {result}");

        result = Multiply(x, y, z);
        Console.WriteLine($"{x} * {y} * {z} = {result}");

        Console.ReadKey();
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static double Multiply(double x, double y, double z)
    {
        return x * y * z;
    }
}



