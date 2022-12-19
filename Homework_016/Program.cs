// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double []array = new double[5];
for (int i=0; i<array.Length; i++)
array[i] = new Random().Next(0,100)/10.0;
Print(array);

double max = array[0];
double min = array[0];

for (int i=0; i<array.Length; i++) 
 {  if (array[i] < min)
    min = array [i];
    if (array[i] > max)
    max = array[i];
}
Console.Write($"Разница между max и min элементом массива - {Math.Round(max-min,2)}");

void Print(double[]arr)
{
 for (int i=0; i<arr.Length; i++)
    Console.Write($" {arr[i]} ");
 
  Console.WriteLine();
}




