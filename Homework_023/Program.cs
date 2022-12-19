// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,]array = new int [3,4];
for (int i=0; i<array.GetLength(0);i++)
{
  for (int j=0; j<array.GetLength(1);j++)
  {
  array [i,j]=new Random().Next(10);
  Console.Write("{0, 3}",array[i,j] ); 
  }
  Console.WriteLine();}
Console.WriteLine();

int imin = 0;
int min = 0;

for (int i=0; i<array.GetLength(1); i++)
    min = min + array[0,i];

for (int i=1; i<array.GetLength(0); i++)
{   int sum = 0;
  for (int j=0; j<array.GetLength(1);j++)
    sum = sum + array[i,j];
if (sum < min)
{  min = sum;
   imin = i;
}}
  Console.Write($"Строка под номером {imin+1}.Сумма:{min}"); 




