﻿//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Write("Введите занчение : ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите занчение : ");
int M = int.Parse(Console.ReadLine()!);

int SumNum(int start , int end)
{
    if (start == end)
        return end;
    return start + "  " + SumNum(start , end-1);
}
Console.Write(SumNum(N,M));
