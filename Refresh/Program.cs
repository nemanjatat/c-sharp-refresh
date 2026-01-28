double x = 3;
double y = -3;
double z = 3.14;
double w = 3.23;
double t = 3.66;
double n = 10;
double m = 20;

double a = Math.Pow(x, 2);
PrintAndRead(a);

double b = Math.Sqrt(x);
PrintAndRead(b);

double c = Math.Abs(y);
PrintAndRead(c);

double d = Math.Round(z);
PrintAndRead(d);

double e = Math.Ceiling(w);
PrintAndRead(e);

double f = Math.Floor(t);
PrintAndRead(f);

double g = Math.Max(n, m);
PrintAndRead(g);

double h = Math.Min(n, m);
PrintAndRead(h);



static void PrintAndRead(double num)
{
    Console.WriteLine(num);
    Console.ReadKey();
}