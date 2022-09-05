﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число N ");

int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());


int sumTo(int N, int M)
{
    if (N == M)
        return N;
    return N + sumTo(N - 1, M);
}

Console.WriteLine($" Сумма чисел от {N} до {M}: {sumTo(M, N)}");



