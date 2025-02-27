﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) >= 100 && Math.Abs(number) < 1000)  // проверка на трехзначность
{
  int digit12 = number / 10; // целое от деления на 10, первая и вторая цифры числа
  int digit2 = digit12 % 10; // остаток от деления на 10 первых двух цифр, вторая цифра 
  Console.WriteLine($"Вторая цифра числа {number}: {Math.Abs(digit2)}"); // убирает знак у отрицательных чисел
}
else
{
  Console.WriteLine("Число должно быть трехзначным!");
}