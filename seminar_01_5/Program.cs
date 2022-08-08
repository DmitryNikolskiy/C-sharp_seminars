Console.Write("Введите число: ");
int N  = Convert.ToInt32(Console.ReadLine());
int i = -N;

while (i < N+1)
{
    Console.Write(i);
    Console.Write(", ");
    i++;
}