/*
String[] ford = { "Focus", "EcoSport", "Kuga" };
String[] honda = { "Jazz", "Accord", "Civic" };
String[] opel = { "Astra", "Insignia", "Corsa" };
*/

String[,] parkingLot = { { "Focus", "EcoSport", "Kuga" },
                         { "Jazz", "Accord", "Civic"},
                         { "Astra", "Insignia", "Corsa" }
                       };

/*
foreach (String car in parkingLot)
    Console.WriteLine(car);
*/

for (int i = 0; i < parkingLot.GetLength(0); i++)
{
    for (int j = 0; j < parkingLot.GetLength(1); j++)
    {
        Console.Write(parkingLot[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();