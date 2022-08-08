Console.Write("Введите первое число: ");
int number1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2  = Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;
if(square == number1)
{
    Console.WriteLine("Первое число - квадрат второго!");
}
else 
{
    Console.WriteLine("Первое число не является квадратом второго");
}    