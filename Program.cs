using ConsoleT8b.Models;

Class1 fun = new Class1();

Console.Write("Enter number 1: ");
float a = float.Parse(Console.ReadLine());

Console.Write("Enter number 2: ");
float b = float.Parse(Console.ReadLine());

Console.Write("Total= " + fun.Add(a, b));

//________________________________________________________________________________________
Console.Write("\n\nEnter number 1: ");
float a2 = float.Parse(Console.ReadLine());

Console.Write("Enter number 2: ");
float b2 = float.Parse(Console.ReadLine());

Console.Write("Enter number 3: ");
float c2 = float.Parse(Console.ReadLine());

Console.Write("Total= " + fun.Add(a2, b2, c2));

//________________________________________________________________________________________
Console.Write("\n\nEnter number 1: ");
float a3 = float.Parse(Console.ReadLine());

Console.Write("Enter number 2: ");
float b3 = float.Parse(Console.ReadLine());

Console.Write("Enter number 3: ");
string c3 = Console.ReadLine();

Console.Write("Total= " + fun.Add(a3, b3, c3));

//________________________________________________________________________________________
Console.Write("\n\nSalary: ");
float a4 = float.Parse(Console.ReadLine());

Console.Write("Working hours: ");
string b4 = Console.ReadLine();

Console.Write("Total Salary with bounce= " + fun.Add(a4, b4));