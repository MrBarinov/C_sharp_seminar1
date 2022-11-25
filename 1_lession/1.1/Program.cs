// напишите программу, которая на вход принимает два числа и проверяет
// является ли первое число квадратом второго
Console.WriteLine("Write a number One: ");
int num1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Write a number Two: ");
int num2 = int.Parse(Console.ReadLine()); 

if (num2 == num1 * num1)
{
    Console.WriteLine("yes");
}

else
    Console.WriteLine("no");