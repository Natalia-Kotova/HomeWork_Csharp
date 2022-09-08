// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string number1 = Convert.ToString(number);
// int size = number1.Length;

// if(size == 5){
//     if(number1[0]==number1[4] && number1[1]==number1[3]){
//         Console.WriteLine($"Ваше число: {number} - палиндром (читается слева направо и справа налево).");
//     }
//     else{
//         Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
//     }
// }
// else{
//     Console.WriteLine($"Вы ввели не пятизначное число");
// }

// if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
// }
// else{
//     Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// } 


// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// System.Console.WriteLine("Введите координаты Х , Y и Z точки A: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координаты Х , Y и Z точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// //double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
// double result = Math.Sqrt( Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + + Math.Pow((z2-z1),2));
// System.Console.WriteLine($"A({x1} {y1} {z1}), В({x1} {y1} {z1}) -> {result} ");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i =1; i <= n; i++){
//     System.Console.WriteLine(Math.Pow(i, 3)); //если работаем с малым количеством чисел, можно так System.Console.Write($"{Math.Pow(i, 3)} ")
// }