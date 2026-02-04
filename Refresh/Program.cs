// string interpolation = allows us to insert variables into a string literal
//                        precede a string literal with $
//                        {} are placeholders

String name, destination;

Console.Write("What's your name: ");
name = Console.ReadLine();

Console.Write($"It's nice to meet you {name}. Where would you like to go: ");
destination = Console.ReadLine();

Console.Write($"Good news {name}");
for(int i = 0; i < 3; i++)
{
    Console.Write(".");
    Thread.Sleep(1000);
}
Console.WriteLine();
Console.WriteLine($"You are heading to {destination}!");

Console.ReadKey();