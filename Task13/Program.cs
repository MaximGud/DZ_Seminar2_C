// Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 == 0)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine($"Третья цифра семизначного числа {number} равна {number % 100000 / 10000}");
  Console.WriteLine("ДОП:");
  Console.WriteLine($"Третья цифра справа числа {number} равна {number % 1000 / 100}");
}
