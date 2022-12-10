//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int a;

Console.Write($"Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a>99999 || a<10000)
{Console.Write($"Вы ввели неверное число");}

else if (a/10000 == a%10 && a/1000%10 == a%100/10)
{
  Console.Write($"Да! Число {a} - палиндром");
}

else 
{
  Console.Write($"Нет. Число {a} не палиндром");
}


/*int digit;

if (digit[0]=digit[4] && digit[1]=digit[3])

{Console.Write($"Число {a} - палиндром");
}
else

{Console.Write($"Число {a} - НЕ палиндром");
}

*/
