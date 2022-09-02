void Fill(int[,] massive1)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
            {
                if (i == 0) massive1[i,j] = i+j;
                if (j == 3) massive1[i,j] = i+j;
                if (i == 1 && j != 3) massive1[i,j] = i+j+10;
            }
    }
    
    for (int i = 0; i < 4; i++)
    {
        int index = 3;
        for (int j = 2; j >= 0; j--)
            {
                if (i == 3) massive1[i,j] = 4+index;
                if (i == 2 && j != 0) massive1[i,j]=11+index;
                index++;
            }
    }   
    int index2 = 6;    
    for (int i = 2; i >= 1; i--)
    {
        massive1[i,0] = 4+index2;
        index2++;
    }       
}
void Print(int[,] massive2)
{
    for (int k = 0; k < 4; k++)
    {
        for (int l = 0; l < 4; l++)
        {
            Console.Write($"{massive2[k,l]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4,4];
Fill(array);
Print(array);