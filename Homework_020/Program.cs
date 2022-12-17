// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] array = new int[3,4];

for(int i=0; i<array.GetLength(0);i++)
 {for (int j=0; j<array.GetLength(1);j++)
{array[i,j] = new Random().Next(10);
Console.Write($"{array[i,j]} ");}
Console.WriteLine();}
 
int a,b;
Console.Write($"Введите номер строки "); 
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите номер столбца "); 
int.TryParse(Console.ReadLine()!, out b);

if (a<1 || a>array.GetLength(0))
{Console.Write($"неправильный номер строки");}
else if (b<1 || b>array.GetLength(1))
{Console.Write($"неправильный номер столбца");}
else
Console.Write($"{array[a-1,b-1]}");





