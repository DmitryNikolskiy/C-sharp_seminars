Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
int lenght = num.Length;
int div = Convert.ToInt32(Math.Pow(10, (lenght-3)));
if(number > 99)
{
    Console.WriteLine($"Третья цифра: {number / div % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}