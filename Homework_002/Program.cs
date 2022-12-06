
/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
int a;
int b;
int c;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"Введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);

int max=a,

if (b>a)
{
  Console.Write($"Наибольшее число - {b} ");
}

if (c>a)
{
  Console.Write($"Наибольшее число - {c} ");
}

else 
{
  Console.Write($"Наибольшее число - {a} ");
}