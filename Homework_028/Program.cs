// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int m,n;
Console.Write($"Введите M:");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите N:");
int.TryParse(Console.ReadLine()!, out n);

string PrintNums(int left,int right)
{
  if (left>=right)
     return right.ToString();
  return $"{left} {PrintNums(left+1,right)}";
}
int sum=0;
int count;
  if (m>n) count=m-n+1;
  else count=n-m+1;

sum=(m+n)*count/2;
Console.Write($"Сумма элементов: {sum} ");
