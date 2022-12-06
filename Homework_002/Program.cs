int a;
int b;
int c;
int max;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"Введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

Console.Write("Максимальное число - это ");
Console.WriteLine(max);
