// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("----Задача 25----\n");
int A, B, C;
Console.Write("Enter number A: ");
int.TryParse(Console.ReadLine()!, out A);
C = A;
Console.Write("Enter number B: ");
int.TryParse(Console.ReadLine()!, out B);
for (int n = 1; n < B; n++)
    C = C * A;
Console.Write($"А в степени В = {C} ");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("----Задача 27----\n");
int A1, summ = 0;
Console.Write("Enter number A: ");
int.TryParse(Console.ReadLine()!, out A1);
while (A1 != 0)
{
    summ = summ + A1 % 10;
    A1 = A1 / 10;
}
Console.Write($"Summ = {A1} {summ} \n");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("----Задача 29----\n");
int[] arr;
arr = new int[8];
for (int index = 0; index <= 7; index++)
{
    Console.Write($"Enter number {index} to add Array: ");
    int.TryParse(Console.ReadLine()!, out arr[index]);
    Console.Write($"Array[{index}] = {arr[index]} \n");
}
Array.ForEach(arr, Console.WriteLine); // printing all contents of array in C#