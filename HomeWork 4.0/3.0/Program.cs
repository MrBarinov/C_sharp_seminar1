//Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.


void MassivFill(int[] a)
{
    int Lenght = a.Length;
    int i = 0;
    while (i < Lenght)
    {
        a[i] = new Random().Next(1, 100);
        i++;
    }
}

void MassivPrint(int[] c)
{
    int count = c.Length;
    int pos = 0;
    Console.Write("[");
    while (pos < count)
    {
        Console.Write($"{c[pos]}");
        pos++;
        if (pos < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] array = new int[8];

MassivFill(array);
MassivPrint(array);