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


int m;
Console.Write($" Введите числа: ");
int.TryParse(Console.ReadLine()!, out m);

int []array=new int[m];

for (int i = 0; i<m; i++)
  Console.Write($"[{i}] = ");
  int.TryParse(Console.ReadLine()!, out array[i]);

int k=0;
foreach (var int i in array)
  if (i>0)
  k++;

/*int count =0;
for (int i=0; i<m; i++)
   {if (i>0)
count=count+1;
   }
  */
Console.Write($"{k} чисел больше 0");
