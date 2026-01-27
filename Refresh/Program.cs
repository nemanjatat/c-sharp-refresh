// type casting =   Converting a value to a different data type
//                  Useful when we accept uset input (string)
//                  Different data types can do different things

double a = 3.14;
int b = Convert.ToInt32(a);

int c = 1246;
double d = Convert.ToDouble(c) + 0.1; // so it'd show decimals

int e = 123;
String f = Convert.ToString(e);

String g = "@";
char h = Convert.ToChar(g);

String i = "true";
bool j = Convert.ToBoolean(i);

Console.WriteLine(b);
Console.WriteLine(d);
Console.WriteLine(f);
Console.WriteLine(h);
Console.WriteLine(j);

Console.WriteLine(b.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(h.GetType());
Console.WriteLine(j.GetType());

Console.ReadKey();