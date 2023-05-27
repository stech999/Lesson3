// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

Console.Clear();

// Первый метод

// Console.Write("Введите число для проверки в палиндроме: ");
//      bool palindrome = true;
//      int x = int.Parse(Console.ReadLine()!);
//      int c = x.ToString().Length - 1;
//      string b = x.ToString();
//      for (int i = 0; i < c; i++)
//           if (b[i] != b[c - i])
//           palindrome = false;
//           if (palindrome == true)
//           Console.Write("ДА");
//      else Console.Write("НЕТ");


// Второй метод

void tet (int m)
{
    bool palindrome = true;
    int c = m.ToString().Length - 1;
    string b = m.ToString();
    for (int i = 0; i < c; i++)
    if (b[i] != b[c - i])
    palindrome = false;
    if (palindrome == true)
    {
        Console.Write("ДА");
    }
    else Console.Write("НЕТ");
}

Console.Write("Введите число для проверки в палиндроме: ");
int kek = int.Parse(Console.ReadLine()!);
tet(kek);