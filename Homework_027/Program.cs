// Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n;
Console.Write($"Введите N:");
int.TryParse(Console.ReadLine()!, out n);

PrintNums(n,1);

void PrintNums(int left,int right)
{
 if (left<right)
 Console.Write($"{right}");
 else 
 {
  Console.Write($"{right} ");
Console.Write(:={right+1, left);
 }

}
