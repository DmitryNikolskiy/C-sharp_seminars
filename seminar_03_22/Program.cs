Console.WriteLine("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int i = 1;
while (i < N)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
    i++;
}
Console.Write(Math.Pow(N, 2));