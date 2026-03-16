using Refresh;

class Program
{
    static void Main(string[] args)
    {
        // ToString() = converts an object to its string representation so that it is suitable for display

        River river = new River("Sava", "Slovenia", 990, ["Slovenia", "Croatia", "Bosnia & Herzegovina", "Serbia"]);

        Console.WriteLine(river); // river.ToString()

        Console.ReadLine();
    }
}