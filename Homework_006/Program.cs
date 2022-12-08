/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
/*
Console.Write($"Введите число: ");
string number = Console.ReadLine()!;

int a=number.length;

if (a<2),

{Console.Write($"Такой цифры нет");
}
else 
{
  Console.WriteLine(number[2]);
  }
*/



int a;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a>99) 
{
Console.Write($" Третья цифра -{a%10}");
}

else 
{Console.Write($"Третьей цифры нет");
}

