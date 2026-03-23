using Refresh;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();

        // anonymous objects version
        movies.Add(new Movie("Project Hail Mary".ToLower()));
        movies.Add(new Movie("Knowing".ToLower()));
        movies.Add(new Movie("The Grand Budapest Hotel".ToLower()));

        foreach (Movie movie in movies)
        {
            Console.WriteLine(movie);
        }

        Console.ReadLine();
    }
}