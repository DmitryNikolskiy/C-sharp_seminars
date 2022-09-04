int FAkkerman(int N, int M)
{
    if (N == 0) return M + 1;
    else if (N > 0 && M == 0) return FAkkerman(N-1,1); 
    else return FAkkerman(N-1, FAkkerman(N, M-1));
}   
Console.Write("Введите положительное целое число - первый аргумент функции Аккермана: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное целое число - второй аргумент функции Аккермана: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first < 0 || second < 0) { Console.WriteLine("Необходимо ввести корректные аргументы"); }
else { Console.WriteLine($"Значение функции Аккермана с аргументами ({first}, {second}): {FAkkerman(first, second)}"); }