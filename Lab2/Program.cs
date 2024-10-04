using Lab2;

Console.Write("Введите число в восьмеричной системе:");
int n = int.Parse(Console.ReadLine()!);
SystemCount sc = new SystemCount();
Console.WriteLine(sc.ToDec(n));

