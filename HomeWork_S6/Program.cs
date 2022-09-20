// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// double Prompt(string message)
// {
//     Console.Write(message);
//     double result = Convert.Todouble32(Console.ReadLine());
//     return result;
// }

// double [] CreateArray (double lenght)
// {
//     var array = new double[lenght];
//     for (var i = 0; i < array.Length; i++) { 
//         //array[i] = new Random().Next(-9, 10); // на случай заполнения массива случайными числами в полудиапазоне
//         Console.WriteLine($"Введите значение элемента массива с индексом {i}");
//         array[i] = Convert.Todouble32(Console.ReadLine());
//     }
//     return array;
// }

// void PrdoubleArray (double [] array)
// {
//     Console.Write("[");
//     for (double i = 0; i < array.Length-1; i++)
//     {
//         Console.Write($"{array[i]}\t");
//     }
//     Console.Write($"{array[array.Length-1]}]");
//     System.Console.WriteLine();
// }

// double CountPositiveDigits (double [] array)
// {
//     double count = 0;
//     for (double i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         count += 1;
//     }
//     return count;
// }

// double lengthArray = Prompt("Введите длину массива > ");
// double [] array = CreateArray(lengthArray);
// PrdoubleArray(array);
// double CountPositiveDig = CountPositiveDigits(array);
// System.Console.WriteLine($"Количество элементов в массиве, значение которых больше 0 = {CountPositiveDig}");
//Console.WriteLine($"Количество элементов в массиве, значение которых больше 0 = {CountPositiveDigits(array)}"); // или можно объединить две команды 

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Пример - b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// double Prompt(string message)
// {
//     Console.Write(message);
//     double result = Convert.ToDouble(Console.ReadLine());
//     return result;
// }

// double b1 = Prompt("значения b1: ");
// double k1 = Prompt("значения k1: ");
// double b2 = Prompt("значения b2: ");
// double k2 = Prompt("значения k2: ");
// System.Console.WriteLine();
// double х = (b2 - b1) / (k1 - k2);
// double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

// bool Coordinate(double k1, double k2)
// {
//     bool coordinate = false;
//     if(k1 != k2)
//     {
//         coordinate = true;
//     }
//     return coordinate;
// }

// if (Coordinate(k1, k2))
// {
//     Console.WriteLine($"прямые имеют точку пересечения ({х:f2} ; {y:f2})"); // :f2 - определям количество знаков после запятой
// }
// else
// {
//     if (b1 == b2)
//     {
//         Console.WriteLine("прямые совпадают");
//     }
//     else
//     {
//         Console.WriteLine("прямые параллельны");
//     }
// }
