﻿// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

// a1 - промежуточное значение вычисления.
// a2 - искомое значение (вторая цифра трехзначного числа).

int num = new Random().Next(100, 1000);
int a1 = num / 10;
int a2 = a1 % 10;
Console.WriteLine(num);
Console.WriteLine(a2);