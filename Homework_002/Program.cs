int a;
int b;
int c;

Console.Write($"Введите число 1: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Введите число 2: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($"Введите число 3: ");
int.TryParse(Console.ReadLine()!, out c);

int max=a;

if (b>max) {max = b;}
if (c>max) {max =c;}

Console.Write ("max = ");
Console.WriteLine (max);