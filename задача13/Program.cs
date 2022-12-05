// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введи число: ");
int anyNumber = Math.Abs(int.Parse(Console.ReadLine()!));
int num1  = anyNumber;
int count = 0;
while (num1 > 0)
{
 num1 /= 10;
 count++;
}
if(count - 3 >= 0)
{
    while (count -3 > 0)
{
anyNumber = anyNumber / 10;
count --;
}
Console.WriteLine($"Третья цифра {anyNumber % 10}");
}
else
{
    Console.WriteLine($"Третьей цифры нету");
}