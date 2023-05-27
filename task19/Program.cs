// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

Console.Clear();

Console.Write("Введите число для проверки в палиндроме: ");
     bool palindrome = true;
     int x = int.Parse(Console.ReadLine()!);
     int c = x.ToString().Length - 1;
     string b = x.ToString();
     for (int i = 0; i < c; i++)
          if (b[i] != b[c - i])
          palindrome = false;
          if (palindrome == true)
          Console.Write("ДА");
     else Console.Write("НЕТ");


// так и не получилось напистаь через метод void

// void tet (int m)
// {
//     //Console.Write("Введите число для проверки в палиндроме: ");
//     //int m = int.Parse(Console.ReadLine()!);
//     Console.Write(m);
//
//     bool palindrome = true;
//     //Console.Write(m);
//     int n = Int32.Parse(Console.ReadLine()!);
    
//     int c = n.ToString().Length - 1;
//     string b = n.ToString();
//     for (int i = 0; i < c; i++)
//     if (b[i] != b[c - i])
//     palindrome = false;
//     if (palindrome == true)
//     {
//         Console.Write("ДА");
//     }
//     else Console.Write("НЕТ");
//     //return n;
// }

// Console.Write("Введите число для проверки в палиндроме: ");
// int res = int.Parse(Console.ReadLine()!);
// tet(res);