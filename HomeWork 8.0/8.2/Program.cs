//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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
            arr[i, j] = new Random().Next(1, 10);

    return arr;
}
int[,] MatrixProduct(int[,] arr_first, int[,] arr_second)
{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if (row_size != arr_second.GetLength(0) || column_size != arr_second.GetLength(1)) return pr_matrix;

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            pr_matrix[i, j] = arr_first[i, j] * arr_second[i, j];
    return pr_matrix;
}


Console.Write("Введите колличество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine());

Console.Write("Введите колличество строк: 2: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: 2: ");
int column2 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column);
Print(arr_1);

int[,] arr_2 = MassNums(row, column);
Print(arr_2);

int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);