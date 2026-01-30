String playerchoice, opponentChoice;
Random random = new Random();
playerchoice = "";
opponentChoice = "";
bool playAgain = true;

while (playAgain)
{
    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
    playerchoice = Console.ReadLine().ToUpper();

    opponentChoice = random.Next(1, 4).ToString();

    switch (opponentChoice)
    {
        case "1":
            opponentChoice = "ROCK";
            break;
        case "2":
            opponentChoice = "PAPER";
            break;
        case "3":
            opponentChoice = "SCISSORS";
            break;
        default:
            Console.WriteLine("Unknown error");
            break;
    }

    Console.WriteLine($"Player chose: {playerchoice}\nOpponent chose: {opponentChoice}");

    if (playerchoice == opponentChoice)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (playerchoice == "ROCK" && opponentChoice == "SCISSORS")
    {
        Console.WriteLine("Player wins!");
    }
    else if (playerchoice == "ROCK" && opponentChoice == "PAPER")
    {
        Console.WriteLine("Player losses!");
    }
    else if (playerchoice == "PAPER" && opponentChoice == "ROCK")
    {
        Console.WriteLine("Player wins!");
    }
    else if (playerchoice == "PAPER" && opponentChoice == "SCISSORS")
    {
        Console.WriteLine("Player losses!");
    }
    else if (playerchoice == "SCISSORS" && opponentChoice == "PAPER")
    {
        Console.WriteLine("Player wins!");
    }
    else if (playerchoice == "SCISSORS" && opponentChoice == "ROCK")
    {
        Console.WriteLine("Player losses!");
    }
    else
    {
        Console.WriteLine("Error encountered!");
    }

    Console.WriteLine("Play Again? (Y/N)");
    if (Console.ReadLine().ToUpper() == "N")
        playAgain = false;
}