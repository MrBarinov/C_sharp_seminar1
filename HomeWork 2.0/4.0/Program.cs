// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string Num(int num)

{
    while (num < 8)
    {
        if (num == 6 || num == 7)
        {
            return "Выходной! Можно и отдохнуть!";
        }
        else 
        {
            return "Будний день! РАБОТАЕМ!";
        }
    }
    return ("Erorr, число привышает колличество дней в неделе!");
}

Console.Write("Введите день недели: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Num(num));