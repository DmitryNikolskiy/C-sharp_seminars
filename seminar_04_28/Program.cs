Console.WriteLine("Введите число от 1 до N");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Число меньше 1, попробуйте езе раз");
}
else
{
    int result = number;
    for (int i = 1; i < number; i++)
    {
        result = result * i;
    }
    Console.WriteLine($"Произведение чисел {result}");
}
