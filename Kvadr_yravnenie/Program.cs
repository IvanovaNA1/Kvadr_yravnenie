while (true)
{
    Console.WriteLine("Введите a, b, c");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c = Convert.ToDouble(Console.ReadLine());
    double d = b * b - 4 * a * c;
    if (d < 0)
    {
        Console.WriteLine("Корней нет");
    }
    if (d == 0)
    {
        double x = (-b / 2 * a);
        Console.WriteLine($"Корень равен {x}");
    }
    if (d > 0)
    {
        double x1 = (-b - (d * d) / 2 * a);
        double x2 = (-b + (d * d) / 2 * a);
        Console.WriteLine($"Корни равны {x1}, {x2}");
    }
}
