void Fill(int[,,] massive1, int m1, int n1, int o1)
{
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            for (int k = 0; k < o1; k++)
            {
                massive1[i,j,k] = new Random().Next (10, 100);   // как проверить на уникальность не придумал
            }
        }
    }
}
void Print(int[,,] massive2, int m2, int n2, int o2)
{
    for (int p = 0; p < m2; p++)
    {
        for (int q = 0; q < n2; q++)
        {
            for (int r = 0; r < o2; r++)
            {
                Console.Write($"{massive2[p,q,r]} ({p}, {q}, {r}) ");
            }
        }
    }   
}

Console.WriteLine("Введите первый размер для трехмерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй размер для трехмерного массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третий размер для трехмерного массива");
int o = Convert.ToInt32(Console.ReadLine());
if (m < 1 || n < 1 || o < 1)
{
    Console.WriteLine("Размерности массива должны быть не меньше 1, попробуйте еще раз");
}
else
{
int[,,] array = new int[m,n,o];
Fill(array, m, n, o);
Print(array, m, n, o);
}