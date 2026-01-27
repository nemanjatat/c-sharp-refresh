Console.WriteLine("What's your name?");
String name = Console.ReadLine();

Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your name is: " + name);
Console.WriteLine("You are " + age + " years old");

Console.ReadKey();