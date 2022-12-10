// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N;

Console.Write($" Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

for (i=1; i<=N; i++ )
{
Console.Write($"{N*N*N}");
}
