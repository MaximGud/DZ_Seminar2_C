// Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6

Console.Write("Введите число: ");
string number = Console.ReadLine();
int x = number.Length;
if (x<3)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine($"Третья цифра {number} равна {number[2]}");
  Console.WriteLine("ДОП:");
  Console.WriteLine($"Третья цифра справа числа {number} равна {(Convert.ToInt32(number)%1000)/100}");
}
