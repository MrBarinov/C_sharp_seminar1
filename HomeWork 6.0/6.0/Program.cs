//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел вы хотите ввести?: ");
int n = int.Parse(Console.ReadLine());

int CountNum(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите число: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0) count++;
    }
    return count;
}

Console.WriteLine($"Чиcла больше 0: {CountNum(n)}");