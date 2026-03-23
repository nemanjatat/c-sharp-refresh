using Refresh;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();

        Movie movie1 = new Movie("Project Hail Mary".ToLower());
        Movie movie2 = new Movie("Knowing".ToLower());
        Movie movie3 = new Movie("The Grand Budapest Hotel".ToLower());

        movies.Add(movie1);
        movies.Add(movie2);
        movies.Add(movie3);

        foreach (Movie movie in movies)
        {
            Console.WriteLine(movie.name);
        }

        Console.ReadLine();
    }
}