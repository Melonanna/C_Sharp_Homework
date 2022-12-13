// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int []array = new int[5];
for (int i=0; i<array.Length; i++)
array[i] = new Random().Next(0,10);
Print(array);

int max = 0;

for (int i=0; i<array.Length; i++)
     if (array[i] > array[i+1])
     array[i]==max;

Console.Write($"Максимальное число - {max}");

void Print(int[]arr)
{
  for (int i=0; i<arr.Length; i++)
    Console.Write($" {arr[i]} ");
  Console.WriteLine();
}




