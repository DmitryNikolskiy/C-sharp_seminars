Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string numbertext = Convert.ToString(Math.Abs(number));
int length = numbertext.Length;
int sum = int.Parse(numbertext[0].ToString());
for (int i = 1; i < length; i++)
{
        sum = sum + int.Parse(numbertext[i].ToString());
}
Console.WriteLine($"Сумма чисел {sum}");