﻿Console.WriteLine("Введите число X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());

double lenght = Math.Sqrt(Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2)+Math.Pow(Z2-Z1, 2));
Console.WriteLine(lenght); 