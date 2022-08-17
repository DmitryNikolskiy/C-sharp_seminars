int Degree(int a, int b)
{
   int result = 1;
    for (int i = 0; i<b; i++)
    {
        result = result*a;
    } 
    return result;
}

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int deg = Convert.ToInt32(Console.ReadLine());
int power = Degree(number, deg);
Console.WriteLine($"A в степени B = {power}");