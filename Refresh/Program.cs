// arrays = a variable that can store multiple values.
//          fixed size possible

String[] movies = { "The Last Samurai", "The King (2019)", "Good Will Hunting (1997)" };

for (int i = 0; i < movies.Length; i++)
{
    Console.WriteLine(movies[i]);
}

Console.WriteLine("----------------------");
Console.WriteLine("----------------------");
Console.WriteLine("----------------------");

movies[1] = "Gladiator";

foreach (String movie in movies)
{
    Console.WriteLine(movie);
}

// fixed size
String[] destinations = new string[3];

Console.WriteLine("Write 3 places where you'd like to go:");
for (int i = 0; i < destinations.Length; i++)
{
    destinations[i] = Console.ReadLine();
}

Console.WriteLine("Places you'd like to go to are:");

foreach (String destination in destinations)
{
    Thread.Sleep(1000);
    Console.WriteLine(destination);
}

Console.ReadKey();