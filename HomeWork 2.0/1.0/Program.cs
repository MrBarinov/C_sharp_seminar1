// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

string Num(int num)

{
    if (num < 1000)
        return $"Второе число = {num / 10 % 10}";

    else
        return "Число не трехзначное - erorr";
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Num(num));
