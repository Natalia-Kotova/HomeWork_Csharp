// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// алгоритм :
// 1) метод который создает массив
// 2) метод, который выводит массив на экран
// 3) метод, который считает количество элементов, соответствующих требованиям - цикл for с условием if на % 2 == 0 
// 4) вывод в консоль количество или забуферить формулу в результат и вывести результат

// int[] GetArray()
// {
//     int[] array = new int[5];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
// System.Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         System.Console.Write(array[i] + ", ");
//     }
//     System.Console.WriteLine(array[array.Length-1] + "]");
// }

// int CountEvenNumbers(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0 ){
//             count += 1;
//         }
//     }
//     return count;
// }

// int[] array = GetArray();
// PrintArray(array);
// System.Console.WriteLine($"Количество четных чисел в массиве равно {CountEvenNumbers(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// алгоритм :
// 1) метод который создает массив
// 2) метод, который выводит массив на экран
// 3) метод, который считает сумму элементов соответствующих требованиям - цикл for с условием if на  i % 2 != 0 
// 4) вывод в консоль сумму или забуферить формулу в результат и вывести результат

// int[] GetArray()
// {
//     int[] array = new int[5];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
// System.Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         System.Console.Write(array[i] + ", ");
//     }
//     System.Console.WriteLine(array[array.Length-1] + "]");
// }

// int SumOddIndexNumbers(int[] array){
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 0 ){
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// int[] array = GetArray();
// PrintArray(array);
// System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна {SumOddIndexNumbers(array)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// алгоритм :
// 1) метод который создает массив
// 2) метод, который выводит массив на экран
// 3) метод, который находит максимальное и / или минимальное
// 4) метод, который находит максимальное и / или минимальное
// 5) вывод в консоль разница или забуферить формулу в результат и вывести результат

// double[] GetArray(int size)
// {
//     double [] array = new double[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().NextDouble();
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
// System.Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         System.Console.Write(array[i] + ", ");
//     }
//     System.Console.WriteLine(array[array.Length-1] + "]");
// }

// double FindMin(double[] array){
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(array[i] < min){
//             min = array[i];
//         }
//     }
//     return min;
// }

// double FindMax(double[] array){
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(array[i] > max){
//             max = array[i];
//         }
//         }
//     return max;
// }

// double [] array = GetArray(5);
// PrintArray(array);
// double minPosition = FindMin(array);
// double maxPosition = FindMax(array);
// System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxPosition - minPosition}");
