// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.


Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

int max = num1;
int min = num2;

if(num2 > max)
{
    max = num2;
    min = num1;
}
Console.Write("Максимальное = ");
Console.WriteLine(max);
Console.Write("Минимальное = ");
Console.WriteLine(min);