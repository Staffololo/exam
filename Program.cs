﻿//1.  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


// System.Console.WriteLine("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void ShowNumbers(int m, int n)
// {
//     if (m < n)
//     {
//         if(n==m)
//         {
//             System.Console.Write(n );
//             return;
//         }
//         System.Console.Write(m +" ");
//         ShowNumbers(m+1,n);
//     }
//     else
//     {
//         if(n==m)
//         {
//             System.Console.Write(m +" ");
//             return;
//         }
//         System.Console.Write(n +" ");
//         ShowNumbers(m,n+1);
//     }

// }
// ShowNumbers(m,n);

// 2.  Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// System.Console.WriteLine("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int AckermanFunction(int m,int n)
// {
// if(m==0)
// {
//     return n +1;
// }
// if(n == 0)
// {
//     return AckermanFunction(m-1,1);
// }
// return AckermanFunction(m-1,AckermanFunction(m,n-1));


// }
// int resultAckerman=AckermanFunction(m,n);
// System.Console.WriteLine($"Результат функции Аккермана для чисел {m}, {n} : {resultAckerman}");