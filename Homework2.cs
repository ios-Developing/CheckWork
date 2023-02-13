// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("----Задача 10----\n");
Console.Write("Enter number: ");
string input = Console.ReadLine()!;
string number3;
bool number1 = int.TryParse(input, out var number);
if (number1 == true)
{
    number3 = input.ToString();
    Console.Write($"Second number = {number3[1]}");
}
else
    Console.Write($"Not a number: {input}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("----Задача 13----\n");
int input1;
Console.Write("Enter number: ");
int.TryParse(Console.ReadLine()!, out input1);
if (input1 > 99 & input1 < 1000)
{
    int input2 = input1 % 10;
    Console.Write($"Third number = {input2}");
}
else if (input1 > 999)
{
    string input3 = input1.ToString();
    Console.Write($"Third number = {input3[2]}");
}
else
    Console.Write($"There is No number 3! {input1}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("----Задача 15----\n");
int input10;
Console.Write("Enter number: ");
int.TryParse(Console.ReadLine()!, out input10);
if (input10 == 6 || input10 == 7)
    Console.Write($"WOW! Weekend!");
else
    Console.Write($"Bad day...");