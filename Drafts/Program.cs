/*int a;
int b;
int c;

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine()!;
int. TryParse(number1, out a);

Console.Write("Введите второе число: ");
string number2 = Console.ReadLine()!;
int. TryParse(number2, out b);

Console.Write("Введите третье число: ");
string number3 = Console.ReadLine()!;
int. TryParse(number3, out c);
*/

/*?*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

/*int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int n;
for (int n>1; n<=N; n++)

{
Console.Write($" {n} ");
}

*/

/*int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int n=1;

while (n<=N)
{ if (n%2==0) Console.Write($" {n} ");

n++;
}
*/

/*int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int n=1; n<=N;n++)
{if(n%2==0)
  Console.Write($" {n} ");}





/*for (int n>1; n<=N; n++)

{
Console.Write($" {n} ");
}
*/


//int N;
//Console.Write($"Введите число: ");
//int.TryParse(Console.ReadLine()!, out N);

//int n= -N;


//while (n<=N)
// {
 // Console.Write($" {n} ");
 // n++;

 //} 
/*

 int a;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);


if (a<99)
{Console.Write($"Такой цифры нет");}
else
{Console.Write($"Третья цифра - {a%10}");}



*/









/* Выводит случайное число из отрезка  [10,99 ] и показывает наибол цифру числа*/
/*
int num=new Random().Next(10,100);
Console.Write($"{num}");

if (num/10>num%10)
  Console.Write($"   {num/10}");
else
Console.Write($"   {num%10}");
*/

/* Выводит случайное 3 значное число и удаляет среднюю цифру


int num=new Random().Next(100,1000);
Console.Write($"{num}");

int num2=num/100*10+num%10;
Console.Write($"   {num2}");
*/

/*  Прога принимает на вход 2 числа: выводит является ли второе кратным первому 
если не кратно прога выводит остаток от деления

int a,b;


Console.Write($"Введите число 1: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Введите число 2: ");
int.TryParse(Console.ReadLine()!, out b);

if (a%b==0)
{
  Console.Write($"Второе число кратно первому ");
}
else
{
  Console.Write($"Второе число НЕ кратно первому. Остаток = {a%b} ");

}
*/

/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

int a,b;

Console.Write($"Введите число 1: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Введите число 2: ");
int.TryParse(Console.ReadLine()!, out b);

if (a==b*b)
{
  Console.Write($"Первое число является квадратом второго ");
}

if (b==a*a)
{
  Console.Write($"Второе число является квадратом первого ");
}
else
{
  Console.Write($"Ни одно из чисел не является квадратом другого ");

}

*/

/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.*/


int a;

Console.Write($"Введите число 1: ");
int.TryParse(Console.ReadLine()!, out a);

if (a%7==0 || a%23==0) /* && - И,  || - ИЛИ */
{Console.Write($"да!");}

else 
{Console.Write($"нет!");}
