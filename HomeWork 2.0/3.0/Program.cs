// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

string Num(int num)
{
    if (num < 99)
        return "Третьей цифры нет";            

    else 
        return $"Третья цифра - {num % 10}";
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Num(num));