int Sum(int N, int M)
{
    if (N < M) return Sum(N+1, M) + N;
    else return N;
}   

Console.Write("Введите положительное целое число - начало интервала: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное целое число - окончание интервала: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second || first < 0 || second < 0) { Console.WriteLine("Необходимо ввести корректные границы интервала"); }
else { Console.WriteLine($"Сумма чисел в интервале от {first} до {second}: {Sum(first, second)}"); }