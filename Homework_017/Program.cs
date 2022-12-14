
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int M;
Console.Write($"Введите количество чисел: "); 
int.TryParse(Console.ReadLine()!, out M);

int[] array = new int[M];

for (int i = 0; i < M; i++)
  {
    Console.Write($"[{i+1}] = ");
    int.TryParse(Console.ReadLine()!, out array[i]);
  }
int count = 0;
foreach(var i in array)
  if (i>0)
    count++;

Console.Write($"{count} чисел больше 0");



