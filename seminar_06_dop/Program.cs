int Multiplicate(int N)
{
    if (N == 1) return 1;
    else return Multiplicate(N-1) * N;
}

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) { Console.WriteLine("Число меньше 1"); }
else { Console.WriteLine($"Произведение чисел от 1 до {number}: {Multiplicate(number)}"); }