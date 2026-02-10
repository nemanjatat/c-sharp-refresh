/*
String[] ford = { "Focus", "EcoSport", "Kuga" };
String[] honda = { "Jazz", "Accord", "Civic" };
String[] opel = { "Astra", "Insignia", "Corsa" };
*/

String[,] parkingLot = { { "Focus", "EcoSport", "Kuga" },
                         { "Jazz", "Accord", "Civic"},
                         { "Astra", "Insignia", "Corsa" }
                       };

foreach (String car in parkingLot)
    Console.WriteLine(car);

Console.ReadKey();