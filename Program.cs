// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("----Задача 47----\n");
int [,] arr = new int[3, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(100);
          Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("----Задача 50----\n");
int i1, j1;
Console.Write("Enter row index: ");
int.TryParse(Console.ReadLine()!, out i1);
Console.Write("Enter column index: ");
int.TryParse(Console.ReadLine()!, out j1);

if (i1 > arr.GetLength(0) || j1 > arr.GetLength(1))
    Console.Write($"Value arr[{i1}, {j1}] Not exist\n\n");
    else
        Console.Write($"{arr[i1-1, j1-1]} \n\n");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.ф

Console.Write("----Задача 52----\n");
for (int j2 = 0; j2 < arr.GetLength(1); j2++)
{
    int summ = 0;
    double average = 0;
    for (int i2 = 0; i2 < arr.GetLength(0); i2++)
    {
        summ = summ + arr[i2, j2];  
    }
    average = Math.Round((double) summ / arr.GetLength(0), 2);
    Console.Write($"Average column {j2+1}: {average} ");
    Console.WriteLine();
}