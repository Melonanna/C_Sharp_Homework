// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m=3;
int n=2;

Console.Write($"m={m}, n={n} - {Accerman(m,n)} ");

int Accerman(int m,int n)
{
  if (m==0)
    return n+1;
  else if (n==0)
    return Accerman(m-1,1);
  else 
    return Accerman(m-1, Accerman(m,n-1));
}