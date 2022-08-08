Console.WriteLine("Давайте узнаем какое число больше!");
Console.Write("Введите первое число: ");
int number1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2  = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine("Первое число больше второго!");
}
else if(number1 < number2)
{
    Console.WriteLine("Второе число больше первого!");
}
else
{
    Console.WriteLine("Числа равны!");
}    