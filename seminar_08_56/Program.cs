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
int Sum(int[,] massive3, int m3, int n3)
{
    int summa = 0;
    int index = 0;
    for (int o = 0; o < n3; o++)
        {
            summa = summa + massive3[0,o];
        }
    for (int p = 1; p < m3; p++)
    {
        int sum = 0;
        for (int q = 0; q < n3; q++)
        {
            sum = sum + massive3[p,q];
        }
        if (sum < summa) 
        {
            index = p;
            summa = sum;
        }
    }
    return index;
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
Console.WriteLine($"Наименьшая сумма элементов в строке {Sum(array, m, n)} ");
}