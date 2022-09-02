void Fill(int[,] massive1)
{
    for (int i = 0; i < 2; i++)
    {
            for (int j = 0; j < 2; j++)
            {
                massive1[i,j] = new Random().Next (1, 10);
            }
    }
}
void Print(int[,] massive2)
{
    for (int k = 0; k < 2; k++)
    {
        for (int l = 0; l < 2; l++)
        {
            Console.Write($"{massive2[k,l]} ");
        }
        Console.WriteLine();
    }
}
void Multiplicate(int[,] massive3, int[,] massive4)
{
    Console.Write($"{massive3[0,0]*massive4[0,0]+massive3[0,1]*massive4[1,0]} ");
    Console.WriteLine($"{massive3[0,0]*massive4[0,1]+massive3[0,1]*massive4[1,0]}");
    Console.Write($"{massive3[1,0]*massive4[0,0]+massive3[1,1]*massive4[1,0]} ");
    Console.WriteLine($"{massive3[1,0]*massive4[0,1]+massive3[1,1]*massive4[1,1]}");
}    
int[,] array1 = new int[2,2];
int[,] array2 = new int[2,2];
Fill(array1);
Fill(array2);
Print(array1);
Console.WriteLine();
Print(array2);
Console.WriteLine();
Console.WriteLine("Произведение:");
Multiplicate(array1,array2);