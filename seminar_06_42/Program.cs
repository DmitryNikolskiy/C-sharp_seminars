void PrintBinary(int N)
{
    if (N <= 0) return;
    PrintBinary(N/2);
    Console.Write(N%2);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);