void Fill(int[,] massive1, int m1, int n1)
{
    for (int i = 0; i < m1; i++)
    {
            for (int j = 0; j < n1; j++)
            {
                massive1[i,j] = new Random().Next (1, 10);
            }
    }
}
void Print(int[,] massive2, int m2, int n2, int sum2)
{
    sum2 = 0;
    for (int k = 0; k < m2; k++)
    {
        for (int l = 0; l < n2; l++)
        {
            Console.Write($"{massive2[k,l]} ");
            if (k == l) sum2 = sum2 + massive2[k,l];
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма элементов главной диагонали:{sum2}");
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
int sum = 0;
Fill(array, m, n);
Print(array, m, n, sum);
}