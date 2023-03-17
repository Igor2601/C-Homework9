﻿// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;
Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());
WriteLine();
WriteLine(SumElements(m, n));
int SumElements(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return (end + SumElements(start, end-1));
}