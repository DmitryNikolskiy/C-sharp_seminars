void Sequence(int N)
{
    if (N < 1) 
    {
        return;
    }
    Sequence(N-1);
    Console.Write($"{N} ");
}

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Sequence(number);