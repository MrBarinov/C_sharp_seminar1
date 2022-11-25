Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;

Console.Write("Максимальное = ");
Console.WriteLine(max);