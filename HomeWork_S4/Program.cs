// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// double DegreeOfNumber (int a, int b)
// {
//         double Number = Convert.ToDouble(a);
//         double degree = 1;
//         for (int i = 1; i <= b; i++){
//             degree *= Number;
//         } 
//            return degree;
// }

// System.Console.WriteLine($"{a} в степени {b} = {DegreeOfNumber (a , b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumAllDigit(int n){
//     int size = Convert.ToString(n).Length;
//     int sum = 0;
//     int lastDigit = 0;
//         for (int i = 0; i < size; i++)
//     {
//         lastDigit = n % 10;
//         sum += lastDigit;
//         n = n / 10;
//     }

//     return sum;
// }

// int result = SumAllDigit(n);

// System.Console.WriteLine($"Сумма цифр числа {n} -> {result}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] GetArray()
// {
//     int[] result = new int[8];

//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(100);
//     }

//     return result;
// }

// void PrintArray(int[] arr)
// {
//     int i = 0;
//     Console.Write("[");
//     while (i < arr.Length)
//     {
//         Console.Write(arr[i]);
//         i++;
//         if (i < arr.Length)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }

// PrintArray(GetArray());
