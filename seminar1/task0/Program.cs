// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// !!!  Я немного усложнила задачу и сразу сравниваю два числа, введенных пользователем !!!

Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

int max = b;
if (a > max)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}