// nested loops = loops inside of other loops 
//                uses vary - used a lot in sorting algorithms

int rows, columns;
String symbol;

Console.Write("How many rows: ");
rows = Convert.ToInt32(Console.ReadLine());

Console.Write("How many columns: ");
columns = Convert.ToInt32(Console.ReadLine());

Console.Write("What symbol: ");
symbol = Console.ReadLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}