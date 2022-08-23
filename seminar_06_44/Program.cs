void FillArray(int[] ArrayFibo, int number1)
{
    ArrayFibo[0] = 0;
    ArrayFibo[1] = 1;
    for (int i = 2; i < number1; i++)
    {
        ArrayFibo[i] = ArrayFibo[i-1]+ArrayFibo[i-2];
    }
}

void PrintArray(int[] ArrayPr, int number2)
{
        for (int j = 0; j < number2-1; j++)
    {
        Console.Write($"{ArrayPr[j]}, ");
    }
    Console.Write($"{ArrayPr[number2-1]}");
}
Console.Write("Введите числo больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2)
{
    Console.WriteLine("Необходимо значение больше 1");
}
else
{
    Console.WriteLine();
    int [] array = new int[number];
    FillArray(array, number);
    Console.WriteLine("Последовательность Фибоначчи: ");
    PrintArray(array, number);
}