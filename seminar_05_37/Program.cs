void Fill(int[] massive1, int num, int mi, int ma)
{
    for (int i = 0; i < num; i++)
    {
        massive1[i] = new Random().Next (mi, ma + 1);
    }
}
void Print(int[] massive2, int numpr)
{
    Console.Write("[");
    for (int j = 0; j < numpr-1; j++)
    {
        Console.Write($"{massive2[j]}, ");
    }
    Console.Write($"{massive2[numpr-1]}]");
}
Console.Write("Введите размерность массива: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Необходимо значение больше 0");
}
else
{
    Console.WriteLine();
    Console.Write("Введите минимальное число для элемента массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите максимальное число для элемента массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    Fill(array, number, min, max);
    Console.WriteLine("Первоначальный массив: ");
    Print(array, number);
    Console.WriteLine();
    if (number % 2 == 0)
    {
        int numberNew = number /2;
        int[] arrayM = new int[numberNew];
        for (int k = 0; k < numberNew; k++)
        {
            arrayM[k]= array[k]*array[number-k-1];
        }
        Console.WriteLine("Новый массив: ");
        Print(arrayM, numberNew);
    }    
    else
    {
        int numberNew = number /2 + 1;
        int[] arrayM = new int[numberNew];
        for (int k = 0; k < numberNew; k++)
        {
            arrayM[k]= array[k]*array[number-k-1];
        }
        arrayM[numberNew-1] = array[number-number / 2 - 1];
        Console.WriteLine("Новый массив: ");
        Print(arrayM, numberNew);
    }
}