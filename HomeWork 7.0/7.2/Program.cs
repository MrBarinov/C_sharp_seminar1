//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Average(int[,] arr)
{
    double summ;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < column; i++)
    {
        summ = 0;
        for (int j = 0; j < row; j++)
            summ += arr[j, i];
        Console.Write($"{Math.Round(summ / row, 2)}; ");
    }
}

Console.Write("Введите колличество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column);
Print(arr_1);
Average(arr_1);
