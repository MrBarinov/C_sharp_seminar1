﻿//Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.



void MassivFill(int[] a)
{
    int Lenght = a.Length;
    int i = 0;
    while (i < Lenght)
    {
        a[i] = new Random().Next(100, 1000);
        i++;
    }
}




