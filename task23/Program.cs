// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();

// Первое решение

// Console.Write("Введите цифру для расчета куба: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] num = new int[n];
// int z = 0;
// while (z < n)
// {
//     int v = z + 1;
//     Console.WriteLine(v * v * v);
//     z++;
// }

// Второе рещение

void tet (int n)
{
    int[] num = new int[n];
    int z = 0;
    while (z < n)
    {
        int v = z + 1;
        Console.WriteLine(v * v * v);
        z++;
    }
}

Console.Write("Введите цифру для расчета куба: ");
int res = int.Parse(Console.ReadLine()!);
tet(res);