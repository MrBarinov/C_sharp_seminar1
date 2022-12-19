//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

void Summ(int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write($"{sum} ");
        return;
    }
    sum = sum + m;
    Summ(m + 1, n, sum);
}
Summ(1, 15, 0);