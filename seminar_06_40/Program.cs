Console.Write("Введите длину первой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третей стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

if ( a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a) {Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} - существует");}
else {Console.WriteLine($"Треугольника со сторонами {a}, {b} и {c} - не существует");}