// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.


int Num(int num)
{
    Console.WriteLine(num);
    int a = (num);
        return (num / 100 * 10) + (a % 10);
}

Console.WriteLine(Num(new Random().Next(100,1000)));
