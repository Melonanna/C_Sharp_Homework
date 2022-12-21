// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m=2;
int n=3;

Console.Write($"{Accerman(m,n)}");

int Accerman(int m,int n)
{
  if (m==0)
    return n+1;
  else if (n==0)
    return Accerman(m-1,1);
  else 
    return Accerman(m-1, Accerman(m,m-1));
}