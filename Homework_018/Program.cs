// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1,k1,b2,k2;


Console.Write($" Введите число b1: ");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write($" Введите число k1: ");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write($" Введите число b2: ");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write($" Введите число k2: ");
double.TryParse(Console.ReadLine()!, out k2);

if (k1!=k2)
{ double x= (b2-b1)/(k1-k2);
  double y= (k1*x)+b1;
  Console.Write($" ({x};{y}) ");
}
else
  Console.Write($"Данные прямые параллельны (не пересекаются)");

