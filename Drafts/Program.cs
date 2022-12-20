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

/*
int a;

Console.Write($"Введите число 1: ");
int.TryParse(Console.ReadLine()!, out a);

if (a%7==0 || a%23==0) /* && - И,  || - ИЛИ */
/*{Console.Write($"да!");}

else 
{Console.Write($"нет!");}





int a;
bool aflag;

Console.Write($"Введите число: ");
aflag=int.TryParse(Console.ReadLine()!, out a);

if (!aflag) 
{
Console.Write($"вы неправильно ввели число");
}
*/
// прога принимает на вход координаты 2 точек и находит расстояние между ними в 2Д пространстве
/*
int xa, xb, ya, yb;

Console.Write($" Введите координату X точки a: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($" Введите координату Y точки a: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($" Введите координату X точки b: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($" Введите координату Y точки b: ");
int.TryParse(Console.ReadLine()!, out yb);


int x= (xb-xa)*(xb-xa);
int y=(yb-ya)*(yb-ya);

double final= Math.Sqrt(x+y);
Console.WriteLine($"Расстояние между точками = {Math.Round(final,2)}");

*/

// создать массив из 12 элементов,заполненных случайными числами из промежутка -9 9
//найти сумму отрицательных и положительных элементов массива
/*
int[]array = new int[12];
for (int i=0; i<array.Length; i++)

array[i] = new Random().Next(-9,10);
Print(array);

int neg=0;
int pos=0;

int a=5;
int b=3;
int c= a>b ? 0:1;
//если условие верно, выбираем 0 Если неверно -1 
//сокращенный if -тернарное условие - сокращение кода
Console.Write($"\nternar = {c}\n");

for (int i=0; i<array.Length; i++)
{
  if (array[i]>0)
  pos=pos+array[i];
  else 
  neg=neg+array[i];
}
// тернар: pos +=array[i]>0 ? array[i]:0;
//         neg+=array[i]>0 ? array[i]:0;
Console.Write($"Positive sum = {pos}\nnegative sum= {neg}");


// foreach 
/* foreach(int element in array)
  {pos+=element >0 ? element:0;
  neg +=element <0 ? element:0;
  }
*/

/*//функция вывода
void Print(int[]arr)
{
  for (int i=0; i<arr.Length; i++)
    Console.Write($"{arr[i]}");
  Console.WriteLine();
}
*/
/*Двумерные массивы 
string[] arrayS = new string [5];
arrayS[0] = "Vanya";
arrayS[1] = "Sasha";
arrayS[2] = "Ilya";
arrayS[3] = "Petya";
arrayS[4] = "Galia";


//foreach (var item in arrayS)

//{Console.Write($"{item} ");}


//char ans = arrayS[2][3];/*буква h в Sasha*/
/*
for (int i=0; i<arrayS.Length; i++)
{
  for (int j=0; j<arrayS.Length; j++)
{
if (arrayS[i][j] == 'a')
   Console.Write($"{i} {j}\n");

}

}
*/


//заменить все положит на отрицат//

int [] array = new int[10];
for (int i=0; i<array.Length; i++)
  array[i] = new Random().Next(-9,10);

Print(array);


void Invers(int[] arr)
{
  for (int i =0;i<arr.Length; i++)
  arr[i]= -arr[i];
}

Invers(array);
Print(array);


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int []array=new int[5];
for (int i=0; i<array.Length; i++)
array[i]=new Random().Next(-1000,1000);
Print(array);


int count = 0;
for (int i=0; i<array.Length; i++)
{
  if (array[i]>0)
    count = count+1;
}
Console.Write($"Количество чисел больше нуля = {count}");
//функция вывода
void Print(int[]arr)
{
  for (int i=0; i<arr.Length; i++)
    Console.Write($" {arr[i]} ");
  Console.WriteLine();
}

*/


/*
//ALTERNATIVE SOLUTION USING STRING 

string[] numbers = Console.ReadLine()!.Split(' ');
int[] array = new int[numbers.Length];

for (int i=0; i<numbers.Length; i++)
{ int.TryParse(numbers[i], out array[i]);
Console.Write($"{array[i]} ");
}

int count = 0;
foreach(var i in array)
  if (i>0)
    count++;

Console.Write($"\n{count} чисел больше 0");

*/



/*
int[,] array = new int[3,3];
int n = 6;

for(int i=0; i<array.GetLength(0);i++)
{for (int j=0; j<array.GetLength(1);j++)
{array[i,j] = new Random().Next(10);
  Console.Write($"{array[i,j]} ");}
Console.WriteLine();}

bool find = false;
foreach (var i in array)
if (i == n) {find = true; break;}

if (find) 
Console.Write($"Число {n} присутствует");
else 
Console.Write($"Числа {n} в массиве нет");
*/



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

//генерация массива
int [,]array = new int [3,4];
for (int i=0; i<array.GetLength(0);i++)
{
  for (int j=0; j<array.GetLength(1);j++)
  {
  array [i,j]=new Random().Next(10);
  Console.Write("{0, 3}",array[i,j] ); 
  }
  Console.WriteLine();
}
//r - row
for (int r=0; r<array.GetLength(0); r++)
{
 for (int i=0; i<array.GetLength(1); i++)
{
 int k=array[r,i];
 int j=i-1;

while (j>=0 && array [r,j]>k)
{
  array [r,j+1]=array [r,j];
  array [r,j] = k;
  j--;
}
}
}


// вывод
for (int i=0; i<array.GetLength(0);i++)
{
  for (int j=0; j<array.GetLength(1);j++)
  {
  Console.Write("{0, 3}",array[i,j] ); 
  }
  Console.WriteLine();
}