void Fill(int[,] massive1)
{
    for (int i = 0; i < 3; i++)
    {
            for (int j = 0; j < 4; j++)
            {
                massive1[i,j] = new Random().Next (1, 1000);
            }
    }
}
void Print(int[,] massive2)
{
    for (int k = 0; k < 3; k++)
    {
        for (int l = 0; l < 4; l++)
        {
            Console.Write($"{massive2[k,l]} ");
        }
        Console.WriteLine(" ");
    }
}
int[,] array = new int[3,4];
Fill(array);
Print(array);