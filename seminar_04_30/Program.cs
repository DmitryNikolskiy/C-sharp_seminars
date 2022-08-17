void Fill(int[] massive1)
{
    for (int i = 0; i < 8; i++)
    {
        massive1[i] = new Random().Next (0, 2);
    }
}
void Print(int[] massive2)
{
    Console.Write("[");
    for (int j = 0; j < 7; j++)
    {
        Console.Write($"{massive2[j]}, ");
    }
    Console.Write($"{massive2[7]}]");
}
int[] array = new int[8];
Fill(array);
Print(array);