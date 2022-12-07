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

int num=new Random().Next(10,100);
Console.Write($"{num}");

if (num/10>num%10)
  Console.Write($"   {num/10}");
else
Console.Write($"   {num%10}");
