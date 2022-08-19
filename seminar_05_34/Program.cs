void Fill(int[] massive1, int num)
{
    for (int i = 0; i < num; i++)
    {
        massive1[i] = new Random().Next (100, 1000);
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
Console.WriteLine();
int[] array = new int[number];
Fill(array, number);
Console.WriteLine("Массив: ");
Print(array, number);
Console.WriteLine();
int index = 0;
for (int k = 0; k < number; k++)
{
    if (array[k] % 2 == 0)
    {
        index++;
    }
}   
if (index == 0)
{
    Console.WriteLine ("В массиве нет четных чисел");
}
else
{
    Console.WriteLine ($"Количество четных чисел в массиве: {index}");
}


