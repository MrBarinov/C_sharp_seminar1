﻿// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсиaю.

int Summ(int a)
{
    if (a == 0) return 0;
    return Summ(a / 10) + a % 10;

}

Console.WriteLine(Summ(453));