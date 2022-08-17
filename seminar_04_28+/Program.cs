int Multiple(int number)
{
    int result = number;
    for (int index = 1; index < number; index++)
    {
        result = result * index;
    }
    return result;
}

void Fill(int[] massive1)
{
    for (int i = 0; i < 8; i++)
    {
        massive1[i] = new Random().Next (1, 10);
    }
}
void PrintReal(int[] massive2)
{
    Console.Write("[");
    for (int j = 0; j < 7; j++)
    {
        Console.Write($"{massive2[j]}, ");
    }
    Console.Write($"{massive2[7]}]");
}
void PrintMultiple(int[] massive3)
{
    Console.Write("[");
    for (int k = 0; k < 7; k++)
    {
        Console.Write($"{Multiple(massive3[k])}, ");
    }
    Console.Write($"{Multiple(massive3[7])}]");
}
int[] array = new int[8];
Fill(array);
PrintReal(array);
Console.WriteLine();
PrintMultiple(array);