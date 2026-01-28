Random random = new Random();

int dice = random.Next(1, 7);
Console.WriteLine(dice);
Console.ReadKey();

double randomDouble = random.NextDouble();
Console.WriteLine(randomDouble);
Console.ReadKey();

int dndice = random.Next(1, 20);
Console.WriteLine(dndice);
Console.ReadKey();

int dice1 = random.Next(1, 7);
int dice2 = random.Next(1, 7);
int dice3 = random.Next(1, 7);
Console.WriteLine(dice1);
Console.WriteLine(dice2);
Console.WriteLine(dice3);
Console.WriteLine("------\nTotal: " + (dice1 + dice2 + dice3));
Console.ReadKey();