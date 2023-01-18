// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
/*645 -> 6
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int numA = num % 1000;
int result = numA / 100;
if (result != 0)
{
  Console.WriteLine($"{num} -> {result}");  
}
else
Console.WriteLine($"{num} -> Третьего числа нет");
