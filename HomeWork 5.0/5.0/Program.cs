//Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

void Chet(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            num++;
    Console.WriteLine(num);
}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Chet(arr_1);

