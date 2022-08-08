Console.WriteLine("Давайте узнаем какое число больше!");
Console.Write("Введите первое число: ");
int number1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3  = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(max < number2)
{
    max = number2;
}
else if(max < number3)
{
    max = number3;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);