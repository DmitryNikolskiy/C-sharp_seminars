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
void ChangeRowCol(int[,] massive3, int[,] massive4, int m3, int n3)
{
    for (int p = 0; p < m3; p++)
    {
        for (int q = 0; q < n3; q++)
        {
            massive4[q,p] = massive3[p,q];
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
int[,] arraynew = new int[n,m];
Fill(array, m, n);
Print(array, m, n);
Console.WriteLine();
Console.WriteLine("Новый массив:");
ChangeRowCol(array, arraynew, m, n);
Print(arraynew, n, m);
}