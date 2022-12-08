//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
//натуральную степень B. Без модуля Math, используем цикл for.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int Stepen(int A, int B)
{
    int c = 1;
    for (int i = 1; i <= B; i++)
    {
        c = c * A;
    }
    return c;
}

Console.WriteLine(Stepen(a, b));