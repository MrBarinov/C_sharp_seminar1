//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 6] -> 0

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
        arr[i] = new Random().Next(1, 100);
    return arr;
}

void Chet(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 == 0)
            summ = summ + arr[i];
    Console.WriteLine(summ);
}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Chet(arr_1);