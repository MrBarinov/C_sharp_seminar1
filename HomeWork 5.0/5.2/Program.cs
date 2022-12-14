//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


void Print(double[] arr)
{
    int size = arr.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < size - 1)
        {
            Console.Write("; ");
        }
    }
    Console.Write("]");
}

double[] Mass(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble();
        arr[i] *= new Random().Next(100);
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

double Min(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] < min)
        {
            min = arr[i];
        }
    return min;
}

double Max(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] > max)
        {
            max = arr[i];
        }
    return max;
}

double[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine();
Console.WriteLine(Max(arr_1));
Console.WriteLine(Min(arr_1));
Console.WriteLine(Max(arr_1) - Min(arr_1));
