Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Math.Abs(N)];
int number = Math.Abs(N)/N;
int i = 0;
while (i < Math.Abs(N)-1)
{
    array[i] = Convert.ToInt32(Math.Pow(number+i*number, 3));
    Console.Write($"{array[i]}, ");
    i++;
}
Console.Write(Math.Pow(N, 3));