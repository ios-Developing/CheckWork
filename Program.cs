// New file


Console.Write("----Check Work----\n");
string[] arrString;
//arrString = new string[3];
arrString = new string[] {"мама","мыла","раму", "а","папа","не","мыл","раму","кот","сидит","у","кит","рот", "ток", "мышка", "а"};
// Console.Write($"{arrString[0]} \n");
for (int i = 0; i < arrString.Length; i++)
{
    if (arrString[i].Length >= 3)
        Console.Write($"{arrString[i]}, ");    
}
Console.WriteLine("...The End!");