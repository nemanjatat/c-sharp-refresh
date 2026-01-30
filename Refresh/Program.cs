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

    switch (playerchoice)
    {
        case "ROCK":
            if (opponentChoice == "ROCK")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (opponentChoice == "PAPER")
            {
                Console.WriteLine("Computer wins!");
            }
            else
            {
                Console.WriteLine("Player wins!");
            }
            break;
        case "PAPER":
            if (opponentChoice == "ROCK")
            {
                Console.WriteLine("Player wins!");
            }
            else if (opponentChoice == "PAPER")
            {
                Console.WriteLine("It's a tie");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
            break;
        case "SCISSORS":
            if (opponentChoice == "ROCK")
            {
                Console.WriteLine("Computer wins!");
            }
            else if (opponentChoice == "PAPER")
            {
                Console.WriteLine("Player wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
            break;
        default:
            Console.WriteLine("Error encountered");
            break;
    }

    Console.WriteLine("Play Again? (Y/N)");
    if (Console.ReadLine().ToUpper() == "N")
        playAgain = false;
}