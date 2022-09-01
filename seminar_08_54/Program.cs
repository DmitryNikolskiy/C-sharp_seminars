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
void SortRows(int[,] massive3, int m3, int n3)
{
    for (int p = 0; p < m3; p++)
    {
        for (int q = 0; q < n3; q++)
        {
            for (int r = 0; r < n3-1; r++)
            {
                if (massive3[p,r] < massive3[p,r + 1])
                {
                    int temp = massive3[p,r];
                    massive3[p,r] = massive3[p,r+1];
                    massive3[p,r+1] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Введите число строк для массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов для массива");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 1 || n < 1)
{
    Console.WriteLine("Число строк и столбцов должно быть не меньше 1, попробуйте еще раз");
}
else
{
int[,] array = new int[m,n];
Fill(array, m, n);
Print(array, m, n);
Console.WriteLine();
Console.WriteLine("Новый массив:");
SortRows(array, m, n);
Print(array, m, n);
}