// params keyword = a method parameter that takes a variable number of arguments.
//                  the parameter type must be a single - dimensional array

double total = CheckOut(2.99, 3.14, 4.85);

Console.WriteLine(total);
Console.ReadLine();

static double CheckOut(params double[] prices)
{
    double total = 0;

    foreach (double price in prices)
    {
        total += price;
    }

    return total;
}