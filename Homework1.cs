// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("----Задача 2----\n");
int number, number2;
Console.Write("Enter number 1: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write("Enter number 2: ");
int.TryParse(Console.ReadLine()!, out number2);

if (number > number2)
    Console.WriteLine($"Max number: {number}");
else if (number2 > number)
    Console.WriteLine($"Max number: {number2}");
else
    Console.WriteLine($"Number: {number} & Number2: {number2} - equal");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("----Задача 4----\n");
int number, number2, number3;

Console.Write("Enter number 1: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write("Enter number 2: ");
int.TryParse(Console.ReadLine()!, out number2);
Console.Write("Enter number 3: ");
int.TryParse(Console.ReadLine()!, out number3);

int maxNumber = number;

if (number2 > maxNumber)
    maxNumber = number2;
if (number3 > maxNumber)
    maxNumber = number3;
Console.WriteLine($"Max number: {maxNumber}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("----Задача 6----\n");
int number;

Console.Write("Enter number 1: ");
int.TryParse(Console.ReadLine()!, out number);

if (number % 2 == 0)
    Console.Write($"Число {number} четное");
else
    Console.Write($"Число {number} не четное");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("----Задача 8----\n");
int number;
Console.Write("Enter number 1: ");
int.TryParse(Console.ReadLine()!, out number);

for (int i = 2; i <= number; i += 2)
    Console.Write($"{i} ");
