// Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int Summa(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine(Summa(a));