/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
int a;

Console.Write($"Введите число: ");
string number = Console.ReadLine()!;

if (a<99)
{Console.Write($"Такой цифры нет");}
else
{Console.Write($"Цифра = {number[2]}");}
