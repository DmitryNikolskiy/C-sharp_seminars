Console.Write("Введите число: ");
string number = Convert.ToString(Math.Abs(Convert.ToInt32(Console.ReadLine())));
Console.WriteLine($"Количество цифр в этом числе - {number.Length}");