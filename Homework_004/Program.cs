/* VERSION WITH WHILE
int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int n=1;

while (n<=N)
{ if (n%2==0) Console.Write($" {n} ");
n++;
}
*/
/*VERSION WITH FOR*/
int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int n=1; n<=N;n++)
{if(n%2==0)
  Console.Write($" {n} ");}