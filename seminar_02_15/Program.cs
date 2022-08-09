Console.WriteLine("Введите число для дня недели от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
if(day >= 1 & day <= 5)
{
    Console.WriteLine("Нет - это будний день!");
    }
else if(day == 6 | day == 7)
{
    Console.WriteLine("Да - это выходной день!");
}
else
{
    Console.WriteLine("Такого дня недели нет!");
}