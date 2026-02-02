// exception = errors that occur during execution

//      try     = try some code that is considered "dangerous"
//      catch   = catches and handles exceptions when they occur
//      finally = always executes regardless if exception is caught or not

double x, y, result;

try
{
    Console.Write("Enter number 1: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2: ");
    y = Convert.ToDouble(Console.ReadLine());

    if (y == 0)
    {
        Console.WriteLine("You cannot divide by 0!");
    }
    else
    {
        result = x / y;
        Console.WriteLine($"{x} / {y} = {result}");
    }
}
catch (FormatException e)
{
    Console.WriteLine("Type ONLY NUMBERS!");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by 0!");
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong!");
}
finally
{
    Console.WriteLine("Thanks for stopping by!");
}

Console.ReadKey();