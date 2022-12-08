/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. */

//Console.Write($"Введите число: ");
//string number = Console.ReadLine()!;
//Console.Write($"Вторая цифра = {number[1]}");


int a;

Console.Write($"Введите трехзначное число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a>99 && a<1000)
{Console.Write($"Вторая цифра = {a/10%10}");}

else
{Console.Write($"Ваше число не трехзначное. Повторите ввод");}