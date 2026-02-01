// return = returns data back to the place where a method is invoked

Console.Write("Enter number 1: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number 2: ");
double y = Convert.ToDouble(Console.ReadLine());

double result = Multiply(x, y);

Console.WriteLine($"{x} * {y} = {result}");

Console.ReadKey();

static double Multiply(double x, double y)
{
    double result = x * y;
    return result;
}