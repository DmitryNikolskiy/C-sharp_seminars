int Pow(int a, int b)
{
    if (b == 0) 
    {
        return 1;
    }
    return a*Pow(a,b-1);
}

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pow(A, B));