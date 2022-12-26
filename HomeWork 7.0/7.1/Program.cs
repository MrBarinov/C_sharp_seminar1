//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2

//5 9 2 3

//8 4 2 4

//[1, 7] -> такого числа в массиве нет

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(1, 11);

    return arr;
}
string PoiskMeaning(int[,] arr, int poiskRow, int poiskColumn)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    {
        if (poiskRow > row || poiskColumn > column || poiskRow <= 0 || poiskColumn <= 0)
            return $"Числа на такой позиции не существует!";
        return $"Ваше число: arr[{poiskRow}, {poiskColumn}] = {arr[poiskRow - 1, poiskColumn - 1]} ";
    }
}

Console.Write("Введите колличество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column);
Print(arr_1);

Console.Write("Введите строку поиска: ");
int poiskRow = int.Parse(Console.ReadLine());
Console.Write("Введите столбец поиска: ");
int poiskColumn = int.Parse(Console.ReadLine());
Console.WriteLine(PoiskMeaning(arr_1, poiskRow, poiskColumn));
