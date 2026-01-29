List<String> choices = new List<string> { "rock", "paper", "scissors" };
Random random = new Random();

try
{
    Console.Write("Rock, paper or scissors: ");
    String playerChoice = Console.ReadLine().ToLower();

    String opponentChoice = choices[random.Next(0, 3)];

    Console.WriteLine($"Player chose: {playerChoice}\nOpponent chose: {opponentChoice}");

    if (playerChoice == "rock")
    {
        switch (opponentChoice)
        {
            case "scissors":
                Console.WriteLine("Player Wins!");
                break;
            case "paper":
                Console.WriteLine("Player Loses!");
                break;
            case "rock":
                Console.WriteLine("It's a tie!");
                break;
            default:
                break;
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}