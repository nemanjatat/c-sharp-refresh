List<String> choices = new List<string> { "rock", "paper", "scissors" };
Random random = new Random();
int playerPoints, opponentPoints;
playerPoints = 0;
opponentPoints = 0;

while (true)
{
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
                    playerPoints++;
                    break;
                case "paper":
                    Console.WriteLine("Player Loses!");
                    opponentPoints++;
                    break;
                case "rock":
                    Console.WriteLine("It's a tie!");
                    break;
                default:
                    break;
            }
        }
        else if (playerChoice == "paper")
        {
            switch (opponentChoice)
            {
                case "rock":
                    Console.WriteLine("Player Wins!");
                    playerPoints++;
                    break;
                case "scissors":
                    Console.WriteLine("Player Loses!");
                    opponentPoints++;
                    break;
                case "paper":
                    Console.WriteLine("It's a tie!");
                    break;
                default:
                    break;
            }
        }
        else if (playerChoice == "scissors")
        {
            switch (opponentChoice)
            {
                case "paper":
                    Console.WriteLine("Player Wins!");
                    playerPoints++;
                    break;
                case "rock":
                    Console.WriteLine("Player Loses!");
                    opponentPoints++;
                    break;
                case "scissors":
                    Console.WriteLine("It's a tie!");
                    break;
                default:
                    break;
            }
        }
        else
        {
            Console.WriteLine("Unknown command");
        }

        Console.WriteLine($"Player points: {playerPoints}\nOpponent points: {opponentPoints}");
        Console.Write("Would you like to continue playing? (Y/N): ");
        String continuePlaying = Console.ReadLine().ToUpper();
        
        if (continuePlaying == "Y")
        {
            continue;
        }
        else
        {
            break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}