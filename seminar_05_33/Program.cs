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
Console.WriteLine();
Console.Write("Введите минимальное число для элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите максимальное число для элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
Fill(array, number, min, max);
Console.WriteLine("Массив: ");
Print(array, number);
Console.WriteLine();
Console.Write("Введите число для проверки: ");
int test = Convert.ToInt32(Console.ReadLine());
for (int k = 0; k < number; k++)
{
    if (array[k] == test)
    {
        Console.WriteLine ("Да, такое число есть в массиве");
        break;
    }
    else if (array[k] != test)
    {
        Console.WriteLine ("Нет, такого числа нет в массиве");
        break;
    };
}
