﻿void Fill(int[,] massive1, int m1, int n1)
{
    for (int i = 0; i < m1; i++)
    {
            for (int j = 0; j < n1; j++)
            {
                massive1[i,j] = new Random().Next (1, 10);
            }
    }
}
void Print(int[,] massive2, int m2, int n2)
{
    for (int k = 0; k < m2; k++)
    {
        for (int l = 0; l < n2; l++)
        {
            Console.Write($"{massive2[k,l]} ");
        }
        Console.WriteLine();
    }
}

void PrintAverage(int[,] massive3, double m3, int n3)
{
    for (int p = 0; p < n3; p++)
    {
        double average = 0;
        for (int q = 0; q < m3; q++)
        {
            average = average + massive3 [q,p] / m3;
        }  
        Console.WriteLine($"Среднее арифметическое в {p} столбце - {average} ");    
        }
}

Console.WriteLine("Введите число строк для массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов для массива");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 1 || n < 1)
{
    Console.WriteLine("Число строк и столбцов болжно быть больше 1, попробуйте езе раз");
}
else
{
int[,] array = new int[m,n];
int[] average = new int[n];
Fill(array, m, n);
Print(array, m, n);
PrintAverage(array, m, n);
}