// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*6 -> да
7 -> да
1 -> нет*/

Console.Clear();

Console.WriteLine("Введите порядковый номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
int numbers = [1, 2, 3, 4, 5];
int count = 7;

while (num <= count)
{
  if (num == numbers)
  {
    Console.WriteLine($"{num} -> нет");
  }

  else
  {
    Console.WriteLine($"{num} -> да");
  }   
}
Console.WriteLine("Дня недели с данным порядковым номером не существует!!!");

 


