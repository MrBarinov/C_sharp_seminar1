//Напишите программу, которая принимает на 
//вход пятизначное число и проверяет, является ли оно палиндромом.

string Polind(int num)
{
    int a5 = num;
    int a4 = num;
    if (num >= 100000 || num < 10000)
    {
        return "Число не пятизначное";
    }
    else
    {
        a5 = (num % 10); //1
        num = (num / 10); //1232
        a4 = (num % 10); //2
        num = (num / 100); // 12
        if (a4 == (num % 10)) ;
    }
    {
        num = num / 10;
        if (a5 == num)
        {
            return "Это палиндром!";
        }
    }
    return "Не палиндром";

}
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Polind(num));