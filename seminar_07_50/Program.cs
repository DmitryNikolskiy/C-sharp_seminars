void Fill(int[,] massive1, int m1, int n1)
{
    for (int i = 0; i < m1; i++)
    {
            for (int j = 0; j < n1; j++)
            {
                massive1[i,j] = new Random().Next (1, 100);
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

Console.WriteLine("Введите номер строки элемента");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента");
int column = Convert.ToInt32(Console.ReadLine());
if (line >=0 && line < m && column >=0 && column < n )
{
    Console.WriteLine($"Элемент с индексом [{line}, {column}] - {array[line, column]}");
}
else
{
    Console.WriteLine($"Элемента с индексом [{line}, {column}] нет в массиве");
}
}