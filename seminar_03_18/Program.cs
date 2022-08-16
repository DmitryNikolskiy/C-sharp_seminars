Console.WriteLine("Введите номер четверти от 1 до 4: ");
int quater = Convert.ToInt32(Console.ReadLine());
//if(quater == 1)
//{
//    Console.WriteLine("Диапазон возможных значений: X > 0, Y > 0");
//}
//else if(quater == 2)
//{
//    Console.WriteLine("Диапазон возможных значений: X < 0, Y > 0");
//}
//else if(quater == 3)
//{
//    Console.WriteLine("Диапазон возможных значений: X < 0, Y < 0");
//}
//else if(quater == 4)
//{
//    Console.WriteLine("Диапазон возможных значений: X > 0, Y < 0");
//}
string[] arr = {"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};
if(quater >= 1 && quater <= 4)
{
    Console.WriteLine(arr[quater-1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}