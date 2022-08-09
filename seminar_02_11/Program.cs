int number = new Random().Next (100,1000);
Console.WriteLine($"Случайное трехзначное число: {number}");
int digit = number / 100 * 10 + number % 10;
Console.WriteLine($"Новое число (без второ цифры: {digit}");