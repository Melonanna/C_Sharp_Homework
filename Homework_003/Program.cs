int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
Console.Write($"Является ли число четным? ");

if (N%2==0)
{
  Console.Write($"Да");
}

else
{
  Console.Write($"Нет");
}
