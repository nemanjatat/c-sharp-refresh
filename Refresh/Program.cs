// for loop = repeats some code a FINITE amount of times

String message = "Countdown to new year...";

for (int i = 0; i < message.Length; i++)
{
    Console.Write(message[i]);
    Thread.Sleep(200);
}

Console.WriteLine();

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}

Console.WriteLine("HAPPY NEW YEAR!");

Console.ReadKey();