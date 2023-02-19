// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("----Задача 19----\n");
int input;
Console.Write("Enter number: ");
int.TryParse(Console.ReadLine()!, out input);
if (input / 10000 == input % 10 || input / 1000 == input % 100)
    Console.Write($"number => YES");
else
    Console.Write($"number => NO");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("----Задача 21----\n");
double Ax, Ay, Az, Bx, By, Bz;
Console.Write("Enter number Ax: ");
double.TryParse(Console.ReadLine()!, out Ax);
Console.Write("Enter number Ay: ");
double.TryParse(Console.ReadLine()!, out Ay);
Console.Write("Enter number Az: ");
double.TryParse(Console.ReadLine()!, out Az);
Console.Write("Enter number Bx: ");
double.TryParse(Console.ReadLine()!, out Bx);
Console.Write("Enter number By: ");
double.TryParse(Console.ReadLine()!, out By);
Console.Write("Enter number Bz: ");
double.TryParse(Console.ReadLine()!, out Bz);
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double distance = Math.Sqrt(((Bx-Ax)*(Bx-Ax))+((By-Ay)*(By-Ay))+((Bz-Az)*(Bz-Az)));  
Console.Write($"Distance between A ({Ax},{Ay},{Az}) & B ({Bx},{By},{Bz}): {distance}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N;
Console.Write("Enter number N: ");
int.TryParse(Console.ReadLine()!, out N);
for (int count = 1; count <= N; count++)
    Console.Write($" {count * count * count}; ");
