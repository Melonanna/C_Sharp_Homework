/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);


if (N%2==0)
{
  Console.Write($"Да");
}

else
{
  Console.Write($"Нет");
}
