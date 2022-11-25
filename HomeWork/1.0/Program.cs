// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.


Console.Write("Введите число 1: ");
string a = Console.ReadLine();
int num1 = int.Parse(a);
Console.Write("Введите число 2: ");
string b = Console.ReadLine();
int num2 = int.Parse(b);

int max = num1;

if(num2 > max) max = num2;

Console.Write("Максимальное = ");
Console.WriteLine(max);