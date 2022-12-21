// Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n;
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"N = {n} -> {PrintNums(n,1)} ");

string PrintNums(int left,int right)
{
   if (left<=right)
    return left.ToString();
  return $"{left} {PrintNums(left-1, right)}";

}
