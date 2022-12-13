//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0

int []array=new int[4];
for (int i=0; i<array.Length; i++)
  array[i] = new Random().Next(-99,100);

Print(array);

int sum=0;

for (int i=1; i<array.Length; i=i+2)
{
 sum=sum+array[i];
}
Console.Write($"Сумма = {sum}");
//функция вывода
void Print(int[]arr)
{
  for (int i=0; i<arr.Length; i++)
    Console.Write($" {arr[i]} ");
  Console.WriteLine();
}




