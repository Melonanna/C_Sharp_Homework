// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


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
