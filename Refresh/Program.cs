PlayGame();

Console.ReadKey();

static bool PlayGame()
{
    bool startPlaying = true;
    Random random = new Random();
    int numberToGuess = random.Next(1, 101);

    while (startPlaying)
    {
        Console.Write("Enter a number between 1 - 100: ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        if (userGuess > numberToGuess)
        {
            Console.WriteLine("Too high!");
        }
        else if (userGuess < numberToGuess)
        {
            Console.WriteLine("Too low!");
        }
        else
        {
            Console.WriteLine($"Correct! The number is {numberToGuess}");
            return false;
        }
    }

    return false;
}