//Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N

void Square(int N)
{
    int i = 0;
    double num;
    while (i < N)
    {
        i += 1;
        if (i == (N))
        {
            num = Math.Pow(i, 2);
            Console.Write($"{num}");
        }
        else
        {
            num = Math.Pow(i, 2);
            Console.Write($"{num},");
        }
    }
}
Console.WriteLine("введите ч");
int chislo = int.Parse(Console.ReadLine());
Square(chislo);