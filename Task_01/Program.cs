// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();

Console.WriteLine("Введите трёх значное число: ");
int num = int.Parse(Console.ReadLine()!);
int numA = num % 100;
int result = numA / 10;
Console.WriteLine($"{num} -> {result}");