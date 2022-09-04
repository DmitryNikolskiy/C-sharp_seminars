int SumDigit(int N)
{
    if (N / 10 > 0 ) 
    {
        return SumDigit(N / 10) + N % 10;
    }
    else return N;
}

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) 
Console.WriteLine("Необходимо ввести корректное число");
else 
Console.WriteLine($"Сумма цифр в числе {number}: {SumDigit(number)}");