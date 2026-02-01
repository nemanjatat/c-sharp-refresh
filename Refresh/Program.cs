// method = performs a section of code, whenever it's called (invoked)
//          benefit = let's us reuse code without writing it multiple times

Console.Write("Enter your name: ");
String name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

singHappyBday(name, age);
singHappyBday(name, age);
singHappyBday(name, age);

Console.ReadKey();

static void singHappyBday(String birthdayBoy, int yearsOld)
{
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine($"Happy birthday dear {birthdayBoy}!");
    Console.WriteLine($"You are {yearsOld} years old!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine();
}