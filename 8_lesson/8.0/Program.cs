// 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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
void NewString(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < column; i++)
        (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);
}

Console.Write("Введите колличество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column);
Print(arr_1);
NewString(arr_1);
Print(arr_1);