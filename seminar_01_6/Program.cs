Console.Write("Введите трехзначное число: ");
int number  = Convert.ToInt32(Console.ReadLine());
int third = 0;
if(99 < number & number < 1000)
{
    third = number % 10;
    Console.Write("Последняя цифра: ");
    Console.WriteLine(third);
}
else
{
Console.Write("Число не трехзначное!");
}