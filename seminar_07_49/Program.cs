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
void PrintSquaring(int[,] massive3, int m3, int n3)
{
    for (int p = 0; p < m3; p++)
    {
        for (int q = 0; q < n3; q++)
        {
            if (p%2 == 0 && q%2 == 0) Console.Write($"{massive3[p,q]*massive3[p,q]} ");
            else Console.Write($"{massive3[p,q]} ");        
        }
        Console.WriteLine();
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
Fill(array, m, n);
Print(array, m, n);
Console.WriteLine();
PrintSquaring(array, m, n);
}