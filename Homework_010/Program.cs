// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N;

Console.Write($" Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);
int i;

for (i=1; i<=N; i++ )
{
Console.Write($"{i*i*i}");
Console.Write(" ");
}