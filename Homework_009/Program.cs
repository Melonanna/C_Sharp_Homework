// Задача 21 Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

int xa, xb, ya, yb, za, zb;

Console.Write($" Введите координату X точки a: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($" Введите координату Y точки a: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($" Введите координату Z точки a: ");
int.TryParse(Console.ReadLine()!, out za);
Console.Write($" Введите координату X точки b: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($" Введите координату Y точки b: ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($" Введите координату Z точки b: ");
int.TryParse(Console.ReadLine()!, out zb);

double final= Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.WriteLine($"Расстояние между точками = {Math.Round(final,2)}");
