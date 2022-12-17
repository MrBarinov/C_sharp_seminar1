// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

void Print(int[] arr)
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

int[] Mass(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(10, 100);
    }
    return arr;
}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);