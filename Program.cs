// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m_number;
int countMoreThanO = 0;
Input("Сколько чисел будем вводить? ");
int count = m_number;                           //сохраним сколько чисел будем вводить
int[] array_numbers = new int[m_number];

for(int i = 0; i < count; i++){                 //цикл ввода чисел в массив
    Input($"Please enter number {i + 1}: ");
    array_numbers[i] = m_number; 
    if (m_number>0)
        countMoreThanO++;
}
//Console.Write($"Чисел больше 0: {countMoreThanO}\n");
//Console.Write($"Проверьте сами: {String.Join(" , ", array_numbers) }\n");  // printing all contents of array in C# через запятую

Print("Чисел больше 0:", countMoreThanO);
Console.Write($"Проверьте сами: {String.Join(" , ", array_numbers) }\n");  // printing all contents of array in C# через запятую

void Print(string some_text, int result) //Метод вывода
{
    Console.Write($"{some_text} {result}\n");
}

int Input(string some_text) //Метод ввода чисел
{
    Console.Write($"{some_text}");
    int.TryParse(Console.ReadLine()!, out m_number);
    return m_number;
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1 = Input1("Input b1: ");
int k1 = Input1("Input k1: ");
int b2 = Input1("Input b2: ");
int k2 = Input1("Input k2: ");

CrossPoint(k1,b1,k2,b2);

void CrossPoint(double k1, double b1, double k2, double b2)
{
double x = Math.Round((b1-b2)/(k2-k1), 2);
double y = Math.Round((k2*b1-k1*b2)/(k2-k1), 2);
if(k1==k2) Console.Write("Заданные прямые не пересекаются!"); else
    Console.Write($"Точка пересечения заданных прямых: ({x}; {y}) ");
}

int Input1(string some_text) //Метод ввода чисел
{
    int _n;
    Console.Write($"{some_text}");
    int.TryParse(Console.ReadLine()!, out _n);
    return _n;
}