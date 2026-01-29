// hypotenuse of a right triangle
// c = sqrt(a^2 + b^2)

Console.Write("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
Console.WriteLine($"The hypotenuse is: {c}");