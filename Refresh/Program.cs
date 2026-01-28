int numOfAvailableMovies = 5;

Console.WriteLine("-- addition --");
numOfAvailableMovies = numOfAvailableMovies + 1;
numOfAvailableMovies += 1;
numOfAvailableMovies++;
Console.WriteLine(numOfAvailableMovies);
Console.ReadKey();

Console.WriteLine("-- subtraction --");
numOfAvailableMovies = numOfAvailableMovies - 1;
numOfAvailableMovies -= 1;
numOfAvailableMovies--;
Console.WriteLine(numOfAvailableMovies);
Console.ReadKey();

Console.WriteLine("-- multiplication --");
numOfAvailableMovies = numOfAvailableMovies * 2;
numOfAvailableMovies *= 2;
Console.WriteLine(numOfAvailableMovies);
Console.ReadKey();

Console.WriteLine("-- division --");
numOfAvailableMovies = numOfAvailableMovies / 2;
numOfAvailableMovies /= 2;
Console.WriteLine(numOfAvailableMovies);
Console.ReadKey();

Console.WriteLine("-- modulus --");
int remainder;
remainder = numOfAvailableMovies % 2;
Console.WriteLine(remainder);
Console.ReadKey();