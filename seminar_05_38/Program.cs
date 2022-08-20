void Fill(double[] massive1, int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите значение {i+1} элемента массива: ");
        massive1[i] = Convert.ToDouble(Console.ReadLine());
    }
}
void Print(double[] massive2, int numpr)
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
    double[] array = new double[number];
    Fill(array, number);
    Console.WriteLine("Вы сформировали массив: ");
    Print(array, number);
    Console.WriteLine();
    double min = array[0];
    double max = array[0];
    for (int k = 1; k < number; k++)
    {
        if (array[k] < min) 
        {
            min = array[k];
        }
        else if (array[k] > max) 
        {
            max = array[k];
        }
    }
    Console.WriteLine($"Разость между максимальным и минимальными элементами массива: {max - min}");
}