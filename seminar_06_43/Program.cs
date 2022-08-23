Console.Write("Введите коэффициент B1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент K1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент B2: ");
double B2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент K2: ");
double K2 = Convert.ToDouble(Console.ReadLine());

if (K1 != K2)
{
    double x = (B1-B2) / (K2 - K1);
    double y = (K1 * x + B1);
    Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
}
else {Console.WriteLine("Прямые не пересекаются");}