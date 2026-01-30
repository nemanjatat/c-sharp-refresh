Console.WriteLine("------------------");
Console.WriteLine("Calculator Program");
Console.WriteLine("------------------");

do
{
    double num1 = 0;
    double num2 = 0;
    double result = 0;

    Console.Write("Enter number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("--- What would you like to do? ---");
    Console.WriteLine("+\taddition");
    Console.WriteLine("-\tsubtraction");
    Console.WriteLine("*\tmultiplication");
    Console.WriteLine("/\tdivision");
    Console.WriteLine("^\tpow");

    Console.Write("Enter an option: ");

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
            break;
        case "^":
            result = Math.Pow(num1, num2);
            Console.WriteLine($"{num1} ^ {num2} = {result}");
            break;
        default:
            Console.WriteLine("That feature is unavailable");
            break;
    }

    Console.WriteLine("Would you like to continue? (Y = yes, N = no)");
} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Thank you for using the Calculator App!");

Console.ReadKey();