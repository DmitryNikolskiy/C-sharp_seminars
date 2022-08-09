int number = new Random().Next (100,1000);
Console.WriteLine($"Случайное трехзначное число: {number}");
int digit = number / 10 % 10;
Console.WriteLine($"Вторая цифра этого числа: {digit}");