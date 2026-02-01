// foreach loop = a simpler way to iterate over an array, but it's less flexible

String[] trains = { "Orient Express", "Flying Scotsman", "Golden Arrow" };
String message = "Available Trains";

for (int i = 0; i < message.Length; i++)
{
    Console.Write(message[i]);
    Thread.Sleep(200);

    if (i == message.Length - 1)
        Console.WriteLine();
}

foreach (String train in trains)
{
    Thread.Sleep(500);
    Console.WriteLine(train);
}

Console.ReadKey();