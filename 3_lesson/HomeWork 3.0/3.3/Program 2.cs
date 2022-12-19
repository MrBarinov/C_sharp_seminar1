//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int N)
{
    for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"{i} - {Math.Pow(i, 3)}");
        }
}
Console.WriteLine("Введите число: ");
int table = int.Parse(Console.ReadLine());
Cube(table);