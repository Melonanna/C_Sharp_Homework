// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//генерация массива
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
// сортировка по убыв
for (int i=0; i<array.GetLength(0);i++)
{
  for (int j=1; j<array.GetLength(1);j++)
{
 for (int k=0; k<array.GetLength(1)-1;k++)
 {
  if (array[i,k]<array[i,k+1])
  (array [i,k+1], array [i,k]) = (array[i,k], array[i,k+1]);
 }}}
// вывод
for (int i=0; i<array.GetLength(0);i++)
{
  for (int j=0; j<array.GetLength(1);j++)
  {Console.Write("{0, 3}",array[i,j] );}
Console.WriteLine();}