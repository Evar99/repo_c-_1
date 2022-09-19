// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int usernumber = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(usernumber) >= 100)  
{
  int number = Math.Abs(usernumber);
      while (number > 999)
      {
        number = number / 10;
      }
      int digit3 = number % 10; //остаток от деления на 10 трехзначного числа, третья цифра
      Console.WriteLine($"Третья цифра числа {usernumber}: {digit3}");
}
else
{
  Console.WriteLine("Третьей цифры нет");
}