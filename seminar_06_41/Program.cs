void Fill(int[] massive1, int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число номер {i+1}: ");
        massive1[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void Print(int[] massive2, int numpr)
{
        for (int j = 0; j < numpr-1; j++)
    {
        Console.Write($"{massive2[j]}, ");
    }
    Console.Write($"{massive2[numpr-1]}");
}
Console.Write("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Необходимо значение больше 0");
}
else
{
    Console.WriteLine();
    int[] array = new int[number];
    Fill(array, number);
    Console.WriteLine("Вы ввели числа: ");
    Print(array, number);
    Console.WriteLine();
    int index = 0;
    for (int k = 0; k < number; k++)
    {
        if (array[k] > 0) { index++; }
    }
    Console.WriteLine($"Количество чисел больше ноля - {index}");
}