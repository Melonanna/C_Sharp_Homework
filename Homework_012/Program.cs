// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int a;

Console.Write($" Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int b=a;
int sum=0;

while (b>0)
{sum = sum+b%10;
b=b/10;
}

Console.Write($" Сумма цифр: {sum}");
