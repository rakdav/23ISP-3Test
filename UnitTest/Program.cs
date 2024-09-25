using UnitTest;

int a, b;
Console.Write("Введите первое число:");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите второе число:");
int.TryParse(Console.ReadLine()!, out b);
Console.WriteLine($"{a}+{b}={MyMath.Sum(a,b)}");
Console.WriteLine($"{a}!={MyMath.Fact(a)}");
Console.WriteLine($"{b}!={MyMath.Fact(b)}");