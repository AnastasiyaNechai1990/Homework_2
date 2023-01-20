// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*6 -> да
7 -> да
1 -> нет*/

Console.Clear();

Console.WriteLine("Введите порядковый номер дня недели: ");
int x = int.Parse(Console.ReadLine()!);
int numA = 6;
int numB = 7;

if (x == numA || x == numB)
{
  Console.WriteLine($"{x} -> да, это выходной день");  
}
else if (x < numB || x < numB)
{
 Console.WriteLine($"{x} -> нет, это не выходной день"); 
} 
else
{
  Console.WriteLine("Дня недели с данным порядковым номером не существует");
}


