// conditional operator = used in conditional assignment if a condition is true/false

// (condition) ? x : y

var availableMovies = new List<String>
{
    "THE LAST SAMURAI",
    "GOOD WILL HUNTING",
    "STAR WARS"
};

Console.Write("Which movie are you looking for: ");
String movieSelect = Console.ReadLine().ToUpper();

var message = (availableMovies.Exists(movie => movie == movieSelect)) ? "That movie is available" : "That movie is NOT available!";

Console.WriteLine(message);

Console.ReadKey();