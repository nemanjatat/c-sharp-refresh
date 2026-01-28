List<String> choices = new List<string> { "rock", "paper", "scissors" };
Random random = new Random();

try
{
    Console.Write("Rock, paper or scissors: ");
    String playerChoice = Console.ReadLine().ToLower();

    String opponentChoice = choices[random.Next(0, 3)];

    if (playerChoice == "rock" && opponentChoice == "scissors")
        Console.WriteLine("Player wins!");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}