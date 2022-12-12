//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int a,b;

Console.Write($" Введите число A: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($" Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);

if (b==0)
{Console.Write($"1");
}
else
{
  int result = 1;
  for (int i = 0; i<b; i++)
  result = result*a;
  Console.Write(result);
}








/*
Console.Write($" Введите число a: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($" Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);

if (b>0)
{
Console.Write($"{Math.Pow(a,b)}");
}
else 
{
Console.Write($"{Math.Pow(a,-b)}");
}

*/