/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void SortingRowsArrayMaxMin(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int n = 0; n < matrix.GetLength(1) - 1; n++)
//             {
//                 if (matrix[i, n] < matrix[i, n + 1])
//                 {
//                     int temporary = matrix[i, n + 1];
//                     matrix[i, n + 1] = matrix[i, n];
//                     matrix[i, n] = temporary;
//                 }
//             }
//         }
//     }
// }

// /* или решить через метод создания нового массива  */

// int [,] SortingRowsArrayMaxMin(int[,] matrix)
// {
//     int [,] sortingMatix= matrix;
//     for (int i = 0; i < sortingMatix.GetLength(0); i++)
//     {
//         for (int j = 0; j < sortingMatix.GetLength(1); j++)
//         {
//             for (int n = 0; n < sortingMatix.GetLength(1) - 1; n++)
//             {
//                 if (sortingMatix[i, n] < sortingMatix[i, n + 1])
//                 {
//                     int temporary = sortingMatix[i, n + 1];
//                     sortingMatix[i, n + 1] = sortingMatix[i, n];
//                     sortingMatix[i, n] = temporary;
//                 }
//             }
//         }
//     }
//     return sortingMatix;
// }

// int[,] myarray = GenerateArray(rows: 3, columns: 3, minRnd: 0, maxRnd: 10);
// PrintArray(myarray);
// int [,] sortingArray = SortingRowsArrayMaxMin(myarray);
// PrintArray(sortingArray);

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int MinSumElementsRow(int[,] array)
// {
//     int minRow = 0;
//     int sumElementRow = 0;
//     int minSumRow = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         minSumRow += array[0, j];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++) sumElementRow += array[i, n];
//         if (sumElementRow < minSumRow)
//         {
//             minSumRow = sumElementRow;
//             minRow = i;
//         }
//         sumElementRow = 0;
//     }
//     return minRow;
// }

// int[,] myarray = GenerateArray(rows: 3, columns: 2, minRnd: 0, maxRnd: 10);
// PrintArray(myarray);
// System.Console.WriteLine($"В данном массиве, строка {MinSumElementsRow(myarray)+1} это строка с наименьшей суммой элементов");

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[,] FillArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] MultypliMatrix(int[,] firstMaxrix, int[,] secondMaxrix)
// {
//     int[,] resultMatrix = new int[firstMaxrix.GetLength(0), firstMaxrix.GetLength(1)];
//     for (int i = 0; i < firstMaxrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondMaxrix.GetLength(1); j++)
//         {
//             resultMatrix[i, j] = 0;
//             for (int k = 0; k < firstMaxrix.GetLength(1); k++)
//             {
//                 resultMatrix[i, j] += firstMaxrix[i, k] * secondMaxrix[k, j];
//             }
//         }
//     }
//     return resultMatrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int size = Prompt("Введите размер двух матриц: ");
// int[,] firstMaxrix = FillArray(size, size);
// System.Console.WriteLine("Первая матрица > ");
// PrintArray(firstMaxrix);
// int[,] secondMaxrix = FillArray(size, size);
// System.Console.WriteLine("Вторая матрица > ");
// PrintArray(secondMaxrix);
// int[,] result = MultypliMatrix(firstMaxrix, secondMaxrix);
// System.Console.WriteLine("Результат умножения двух матриц > ");
// PrintArray(result);

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int [,] CreateArray (int size){
//     int[,] matrix = new int[size, size];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = 0;
//         }
//     }
//     return matrix;
// }

// int[,] GetSpiralMatrix(int [,] matrix)
// {
//     int[,] spiralMatrix = matrix;
//     int size = matrix.GetLength(0);
//     for (int i = 0; i < spiralMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < spiralMatrix.GetLength(1); j++)
//         {
//             int num = 1;
//             for (int step = 0; step < size - 2; step++)
//             {
//                 for (int n = 0 + step; n < size - step; n++)
//                 {
//                     spiralMatrix[0 + step, n] = num;
//                     num++;
//                 }
//                 num--;
//                 for (int n = 0 + step; n < size - step; n++)
//                 {
//                     spiralMatrix[n, size - 1 - step] = num;
//                     num++;
//                 }
//                 num--;
//                 for (int n = size - 1 - step; n >= 0 + step; n--)
//                 {
//                     spiralMatrix[size - 1 - step, n] = num;
//                     num++;
//                 }
//                 num--;
//                 for (int n = size - 1 - step; n >= 1 + step; n--)
//                 {
//                     spiralMatrix[n, 0 + step] = num;
//                     num++;
//                 }
//             }
//         }
//     }
//     return spiralMatrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int size = Prompt("Введите размер массива: ");
// int [,] matrix = CreateArray(size);
// int [,] spiralMatrix = GetSpiralMatrix(matrix);
// PrintArray (spiralMatrix);
