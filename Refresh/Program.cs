// switch = an efficient way to avoid writting too many if statements

Console.WriteLine("Would you like to manually set current day, " +
    "or let the system do it automatically? (M/A)");
String userChoice = Console.ReadLine().ToUpper();

if (userChoice == "M")
{
    Console.Write("What day of the week is it: ");
    String userDayOfTheWeek = Console.ReadLine().ToUpper();

    switch (userDayOfTheWeek)
    {
        case "MONDAY":
            Console.WriteLine("Today is MONDAY!");
            break;
        case "TUESDAY":
            Console.WriteLine("Today is TUESDAY");
            break;
        case "WEDNESDAY":
            Console.WriteLine("Today is WEDNESDAY");
            break;
        case "THURSDAY":
            Console.WriteLine("Today is THURSDAY");
            break;
        case "FRIDAY":
            Console.WriteLine("Today is FRIDAY");
            break;
        case "SATURDAY":
            Console.WriteLine("Today is SATURDAY");
            break;
        case "SUNDAY":
            Console.WriteLine("Today is SUNDAY");
            break;
        default:
            Console.WriteLine("I am confused");
            break;
    }
}
else if (userChoice == "A")
{
    Console.WriteLine($"Today is {DateTime.Now.DayOfWeek.ToString().ToUpper()}");
}
else
{
    Console.WriteLine("Huh?");
}

Console.ReadKey();