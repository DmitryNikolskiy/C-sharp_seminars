void Fill(int[] massive1)
{
    for (int i = 0; i < 12; i++)
    {
        massive1[i] = new Random().Next (-9, 10);
    }
}
void PrintReal(int[] massive2)
{
    Console.Write("[");
    for (int j = 0; j < 11; j++)
    {
        Console.Write($"{massive2[j]}, ");
    }
    Console.Write($"{massive2[11]}]");
}
int[] array = new int[12];
Fill(array);
PrintReal(array);
int sumplus = 0;
int summinus = 0;
for (int k = 0; k < 12; k++)
{
    if (array[k] > 0)
    {
        sumplus+= array[k];
    }
    else
    {
        summinus+= array[k];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов: {sumplus}");
Console.WriteLine($"Сумма отрицательных элементов: {summinus}");