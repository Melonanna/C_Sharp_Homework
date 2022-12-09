//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int a;

Console.Write($"Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a>99999 || a<10000)
{Console.Write($"Вы ввели неверное число");}

else
{
  Console.Write($"молодец!");
}

int digit;

if (digit[0]=digit[4] && digit[1]=digit[3])

{Console.Write($"Число {a} - палиндром");
}
else

{Console.Write($"Число {a} - НЕ палиндром");
}

