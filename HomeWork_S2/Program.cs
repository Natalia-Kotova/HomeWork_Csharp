// Задача №15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day == 6 || day == 7){
//     System.Console.WriteLine("Этот день выходной");
// }
// else if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5){
// 	System.Console.WriteLine("Этот день рабочий");
//     }
// else{
//     System.Console.WriteLine("Неверный день недели");
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int n = new Random().Next(100, 1000);

// System.Console.WriteLine(n);

// int d1 = n / 100;   // первое число 4
// int d2 = (n / 10) - (d1 * 10);    // второе число 5

// System.Console.WriteLine(d2);

//Решение может быть и таким:

// int n = new Random().Next(100, 1000);
// System.Console.WriteLine(n);

// string n2 = Convert.ToString(n);
// int size = 3;

// int IndexTwoDigit = size - 2;

// Console.WriteLine("вторая цифра -> " + n2[IndexTwoDigit]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// string Number2 = Convert.ToString(Number);
// int size = Number2.Length;

// int IndexThreeDigitOnTheRigt = size - 3;

// if (size > 2){
//     Console.WriteLine("третья цифра -> " + Number2[IndexThreeDigitOnTheRigt]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }
