/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void ShowNumbers(int number)
// {
//     if (number <= 0)
//     {
//         return;
//     }
//     System.Console.Write($"{number} ");
//     ShowNumbers(number - 1);
// }

// int number = Prompt("Введите номер >");
// System.Console.Write($"N = {number} -> ");
// ShowNumbers(number);

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNaturalNumbers(int start, int stop)
// {
//     if (start < stop || start > stop)
//     {
//         return (start + SumNaturalNumbers(start + 1, stop));
//     }
//     if (start == stop) return start;
//     return start;
// }

// int start = Prompt("Введите первое числое > ");
// int stop = Prompt("Введите второе число > ");
// int result = SumNaturalNumbers(start, stop);
// Console.WriteLine($"Сумма натуральных чисел в промежутке [{start}, {stop}] -> {result}");

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// bool Ackermann(int numberM, int numberN)
// {
//     if (numberM > -1 && numberM < 4)
//     {
//         if (numberN > -1 && numberN < 4)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int AckermannFunction(int numberM, int numberN)
// {
//     if (numberM == 0) return numberN + 1;
//     if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
//     if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
//     return AckermannFunction(numberM, numberN);
// }

// System.Console.WriteLine("Расчет вычисления функции Аккермана для чисел m и n");
// int numM = Prompt("Введите число m > ");
// int numN = Prompt("Введите число n > ");
// if (Ackermann(numM, numN))
// {
//     int result = AckermannFunction(numM, numN);
//     Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {result}");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели некорректные числа, пожалуйста, введите другие ");
// }
