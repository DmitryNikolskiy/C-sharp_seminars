Console.Write("Введите число: ");
int N  = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < N+1)
{
    if(i % 2 == 0)
    {
    Console.WriteLine(i);
    }
    i++;
}