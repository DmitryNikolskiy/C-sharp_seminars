Console.Write("Ввод числа А: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i<=number; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Результат работы программы = {sum}");