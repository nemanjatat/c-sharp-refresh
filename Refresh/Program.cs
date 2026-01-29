String fullName = "Nem Tat";
String phoneNumber = "123-456-7890";

Console.WriteLine(fullName.ToUpper());
Console.WriteLine(fullName.ToLower());

Console.WriteLine(phoneNumber.Replace("-", "/"));

String username = fullName.Replace(" ", "").ToLower();
username = username.Insert(0, "@");
Console.WriteLine(username);

Console.WriteLine(fullName.Length);

String firstName = fullName.Substring(0, 3);
String lastName = fullName.Substring(4, 3);

Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}");

Console.ReadKey();