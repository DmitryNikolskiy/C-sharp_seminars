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
void ChangeRows(int[,] massive3, int m3, int n3)
{
    int temp = 0;
    for (int p = 0; p < m3; p++)
    {
        for (int q = 0; q < n3; q++)
        {
            if (p == 0) 
            {
                temp = massive3[p,q];
                massive3[p,q] = massive3[m3-1,q];
                massive3[m3-1,q] = temp; 
            }
        }
    }
}
Console.WriteLine("Введите число строк для массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов для массива");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 2 || n < 1)
{
    Console.WriteLine("Число строк должно 2 и больше 1, а столбцов - не меньше 1, попробуйте еще раз");
}
else
{
int[,] array = new int[m,n];
Fill(array, m, n);
Print(array, m, n);
Console.WriteLine();
Console.WriteLine("Новый массив:");
ChangeRows(array, m, n);
Print(array, m, n);
}