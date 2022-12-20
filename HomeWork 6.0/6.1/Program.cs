//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double b1, double k1, double b2, double k2)
{
    double a = k1 - k2;
    double b = b2 - b1;
    if (a != 0)
    {
        double x = b / a;
        double y = k1 * x + b1;
        Console.WriteLine($"Точки пересечения: ({x}; {y})");
    }
    else if (a == 0)
        Console.WriteLine($"Значение k1 и k2 не должны быть одинаковы");
}
Intersection(int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()));
