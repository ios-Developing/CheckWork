// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("----Задача 34----\n");
int[] array = FillArray(10, 100, 999);
int evenNumber = array.Length;
Console.Write($"{String.Join(" , ", array) }\n");

foreach (int each in array) 
{
    evenNumber = evenNumber - each % 2; // расчет чётных чисел в массиве.
}
Console.Write($"Kоличество чётных чисел в массиве: {evenNumber}\n\n"); //вывод кол-ва чётных чисел в массиве.

int[] FillArray(int size, int min = 100, int max = 999) //заполнение случайными положительными трёхзначными числами
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("----Задача 36----\n");
int[] array2 = FillArray1(6, -20, 20);
int oddSumm = 0;                                        // объявление переменной сумма элементов, стоящих на нечётных позициях.
Console.Write($"{String.Join(" , ", array2) }\n");

for (int index = 1; index < array2.Length; index += 2)
    oddSumm = oddSumm + array2[index];

Console.Write($"Cумма элементов, стоящих на нечётных позициях: {oddSumm}\n\n"); //вывод кол-ва чётных чисел в массиве.

int[] FillArray1(int size, int min = 100, int max = 999) //заполнение случайными положительными трёхзначными числами
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("----Задача 38----\n");
int[] array3 = FillArray2(10, 20, 200);
int max, min, diff;                                        // объявление переменных
Console.Write($"{String.Join(" , ", array3) }\n");

max = array3[0];
min = array3[0];

foreach(int each in array3)
{
    if (each > max)
        max = each;
    else if (each < min)
        min = each;
}
diff = max - min;   //Найдите разницу между максимальным и минимальным элементов массива

Console.Write($"Max: {max}\nMin: {min}\nPазницa между максимальным и минимальным элементов массива: {diff}\n"); //вывод чисел

int[] FillArray2(int size, int min = 100, int max = 999) //заполнение случайными положительными трёхзначными числами
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}
