int x; // declaration
x = 123; // initialization

int y = 321; // declaration + initialization

int z = x + y;

Console.WriteLine($"{x} + {y} = {z}");

int age = 63; // integer = whole number
double price = 14.99; // decimal number
bool onSale = false; // boolean = true or false
char symbol = '@'; // single character
String name = "Tom"; // text

Console.WriteLine($"Your age is: {age}");
Console.WriteLine($"The price for that item is: {price}");
Console.WriteLine($"Item on sale status: {onSale}");
Console.WriteLine($"Chosen symbol: {symbol}");
Console.WriteLine($"Your name is: {name}");

Console.ReadKey();

String username = symbol + name.ToLower();

Console.WriteLine($"Your username is: {username}");

Console.ReadKey();