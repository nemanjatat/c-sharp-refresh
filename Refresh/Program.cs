// if statements
// basic form of decision making

try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age > 100)
    {
        Console.WriteLine("You are too old!");
    }
    else if (age >= 18)
    {
        Console.WriteLine("You are now signed up!");
    }
    else if (age < 0)
    {
        Console.WriteLine("You haven't been borned yet!");
    }
    else
    {
        Console.WriteLine("You must be 18 years or older to sign up!");
    }

    Console.WriteLine("=====================");
    Console.WriteLine("=====================");
    Console.WriteLine("=====================");

    Console.Write("Enter your name: ");
    String name = Console.ReadLine();

    if (name == "")
        Console.WriteLine("You did not enter your name!");
    else
        Console.WriteLine($"Hello {name}!");
}
catch(Exception e)
{
    Console.WriteLine("Please enter a number and nothing else!\n---ERROR MESSAGE---\n" + e);
}