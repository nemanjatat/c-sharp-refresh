// var does not mean any type, it means figure it out for me
// IEnumerable version

var listOfNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var listOfBigNumbers = listOfNumbers.Where(n => n > 4);

foreach (int number in listOfBigNumbers)
    Console.WriteLine(number);

Console.ReadKey();

// Another way to do it with listOfNumbers being a list

var listOfNumbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> listOfBigNumbers2 = listOfNumbers2.Where(n => n > 4).ToList();

foreach (int item in listOfBigNumbers2)
    Console.WriteLine(item);

Console.ReadKey();