// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("----Задача 64----\n");
int number;
int count = 1;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out number);

RowToNumber(number, count);
Console.WriteLine();

void RowToNumber(int n, int count)
{
    if (count > n)
        return;
    else
        RowToNumber(n, count + 1);
        Console.Write(count + " ");
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("----Задача 66----\n");
int m, n;
Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine(), out n);

SumFromMToN(m, n);      // вызов функции "сумма чисел от M до N"
Console.WriteLine();

void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)     // функция сумма чисел от M до N
{
    int result = m;
    if (m == n)
        return 0;
    else
        m++;
        result = m + SumMN(m, n);
        return result;
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("----Задача 68----\n");

int m1, n1;
Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine(), out m1);
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine(), out n1);

Console.Write(Akkerman(m1, n1));
Console.WriteLine();

int Akkerman(int m, int n)      // функция Аккермана
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0)
        return Akkerman(m - 1, 1);
    else
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
}