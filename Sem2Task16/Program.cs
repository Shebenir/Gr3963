﻿// Задача №16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите 2 числа:");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double square = Math.Pow(num1, 2);

if (num2 == square)
{
    Console.WriteLine("Да, число {0} квадрат {1}", num2, num1);
}
else
{
    Console.WriteLine("Нет, число {0} не квадрат числа {1}", num2, num1);
}