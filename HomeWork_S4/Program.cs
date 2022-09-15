﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// тут был комментарий от преподавателя именно через цикл сделать:

//Console.Write("Введите число A: ");            // приглашение на ввод числа
//int a = Convert.ToInt32(Console.ReadLine());   // в переменную а мы кладем число которое ввели с клавиатуры
//Console.Write("Введите число B: ");            // приглашение на ввод
//int b = Convert.ToInt32(Console.ReadLine());   // в переменную b мы кладем число которое ввели с клавиатуры

//double DegreeOfNumber (int a, int b){           // тут мы объясвляем метод (функцию) тип данных double так как работаем со степенью, 
                                                // наименование метода у меня DegreeOfNumber - можешь менять как тебе удобно
                                                // метод относитс к 4 группе - он и принимает и возвращает - принимает он то, что указано в ()
                                                // принимать в нашем случае по умолчаю будет 2 цельных цисла - мы указываем тип данных и имя аргумента
                                                // первое число - тип данных int имя аргумента a, второе число через запятую тип данных int имя аргумента b
//        double degree = 1;                      // наш буфер куда будем копить результат он называется degree - название меняй как хочешь
                                                // почему 1 а не 0? у нас возведение в степень, а это умножение = при умножение на 0 у нас 
                                                // программа бы давала всегда 0 при любом возведение в степень - так что ставо=им 1 чтобы умножение
                                                // шло корректно 
//        for (int i = 1; i <= b; i++){           // вообще решение у нас будет выглядеть так - на примере 2 и 4 = 2 * 2 * 2 * 2 
                                                // цикл такой - повторяем умножение на 2 (в нашем случае число а) до тех пор, пока не упремся 
                                                // в наш размер - он же длитна умножения - он же size - который определяется переменной b
                                                // начинаем с 1 элемента (тут не массив, с 0 не начинаем) можно начать с 0 , но тогда запись будет
                                                // for (int i = 0; i < b; i++){ - иначе посчитает лишнее
//            degree *= a;                        // принцип как возводим в степень - в нашем буфере - хранилище - которое зовем degree уже есть 1
                                                // мы этот в этот degree кладем результат вычисления degree * а, так у нас запоминается 
                                                // результат умножения и мы результат еще раз умножаем на а до тех пор, пока по количеству не 
                                                // пройдем b hfp
//        } 
//           return degree;                       // чтобы этот результат альше можно было где то использовать мы возвращаем degree
//}                                               // конец метода

//System.Console.WriteLine($"{a} в степени {b} = {DegreeOfNumber (a , b)}");    // вывод результата я сразу в выводе вызвала метод DegreeOfNumber (a , b)

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// долго думала - пришла к алгоритму такому - мы разбиваем число на цифры и их суммируем - пробовала решать как через строку по аналогии с массивом
// формула работа - ответ был неправильный - что то не так записала в цикле
// пошла другим путем - через деление на с остатком 10 разбивала число на цифры с конца и остаток суммировала.
// то есть деление с остатком числа 9012 на 10 в остатке дает мне  2 я ее сохраняю в буфер
// далее - делю само число на 10 чтобы оно уменьшилось -  а так как тип int у меня сохраниться только целое число - 9012 / 10 = 901
// теперь уже 901 делю с остатком на 10 - в остатке у меня 1 - ее я плюсую к остатку прошлого деления которое в буфере = 2 + 1 = 3
// далее - делю само число на 10 чтобы оно уменьшилось -  а так как тип int у меня сохраниться только целое число - 901 / 10 = 90
// теперь уже 90 делю с остатком на 10 - в остатке у меня 0 - его я плюсую к остатку прошлого деления которое в буфере = 3 + 0 = 3
// далее - делю само число на 10 чтобы оно уменьшилось -  а так как тип int у меня сохраниться только целое число - 90 / 10 = 9
// теперь уже 9 делю с остатком на 10 - в остатке у меня 9 - его я плюсую к остатку прошлого деления которое в буфере = 3 + 9 = 12
// далее - делю само число на 10 чтобы оно уменьшилось -  у меня результат прошлого деления 0,9 , 0 делить нельзя и именно это и останавливает
// алгоритм в цикле for

//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int SumAllDigit(int n){                      // описываем наш метод - он 4 типа - принимает и возвращает - int - тип данных мы вернем сумм которая
                                            // представлена в целых числах - получаем на вход 1 аргумент - это тоже целое число, поэтому в ()
                                            // у нас тоже будет int и наименование переменой - называй как хочешь - у меня n
    //int size = Convert.ToString(n).Length;  // тут мы пишем строчку чтобы узнать размер числа - Length работает только с типом данных String
                                            // то есть тут я сразу же в переменную size  сконвертировала в тип String число n типа int и применила 
                                            // функцию измерь длину - Length 
    //int sum = 0;                            // наш буфер в котором будет храниться результат - так как эта сумма туда можно положить 0
    //int lastDigit = 0;                      // в этой переменной будет храниться остаток от деления на 10 , он тоже с изначальным значеним 
        //for (int i = 0; i < size; i++)     // цикл - дели с остатком на 10 до тех пор, пока не закончится "размер" числа - деление начинай с 
                                            // с 0 элемента - каждый раз переходи к другому с шагом 1 , от 0 к 1, от 1 к 2, от 2 к 3
    //{
        //lastDigit = n % 10;                 // в переменную lastDigit кладем остаток от деления на 10
        //sum += lastDigit;                   // буфер суммы = к изначальной сумме 0 плюсуй остаток от деления на 10 
        //n = n / 10;                         // уменьшай первое число через деление на 10 - это как count - уменьшает с каждым проходом размер числа
    //}

    //return sum;                             // возвращай - то есть храни в базе памяти число в переменной sum
//}

//int result = SumAllDigit(n);                // тут пошла другим путем - сначала в переменную result  положила результат метода SumAllDigit

//System.Console.WriteLine($"Сумма цифр числа {n} -> {result}");   //  и уже тут вывела результат через переменную result 
                                                                // можно было запись сделать вот так System.Console.WriteLine($"Сумма цифр числа {n} -> {SumAllDigit(n)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// програма будет состоять из 3 частей
// 1 - метод который создаст массив из случайных чисел (как создавать из заданных не совсем поняла, мне проще через случайные)
// 2 - метод который созданный массив выведет на экран в консоли
// то есть в шаге 1 и 2 мы объяснили программе как эту задачу нужно решать, но не дали команду реши задачу - только описали решение 
// 3 - сама команда вызова метода

//int[] GetArray(){                            // 1 метод который создает нам массив  - 3 группа методов - не принимает (мы же с 0 создаем массив)
                                            // но возвращает данные - тип возвращаемых данных - массив - он обозначается как int[] , 
                                            // имя метода GetArray - называй как хочешь в () ничего не указываем так как мы создаем массив с 00
//    int[] result = new int[8];              // в переменную типа массив int[] с названием result мы кладем пустоту в размере 8 ячеек 
                                            // new int[размер массива] - устойсивая формулировка создания нового массива нужного тебе размера 
//    for (int i = 0; i < result.Length; i++) // цикл - до тех пор, пока мы не "уткнемся" в указанный размер (тут сократила запись до result.Length)
                                            // заполняй элементы массива с именем result рандомными числами из указанного диапазона
                                            // шаг действий 1 - начинаем с 0 элемента массива , от 0 к 1, от 1 к 2 и т.д.
//    {
//        result[i] = new Random().Next(100); // тут присвоение в элемент массива result под индексом i клади новое случайное число из диапазона
//    }

//    return result;                          // запомни result - а это наш массив, из 8 элементов , которы заполнен случайными числами
//}

//  с выводом на печать я заморочилась и создала немного сложную формулировку, но которая визуально выводит именном так [1, 2, 5, 7, 19]
//void PrintArray(int[] arr)                  // 2 метод - который выводит на печать - тип void так как нам не надо в памяти программы держать результат
                                            // PrintArray - имя метода - называй кака хочешь - 2 группа методов - принимает но не выводит
                                            // принимает на вход массив - так то в () указывам тип данных int[] - массив и имя массива - arr
//{
//    int i = 0;                              // вводим знаение индекса - i начинаем с 1 элемента который в массиве идет под 0 
//    Console.Write("[");                     // выведи в начале [
//    while (i < arr.Length)                  // до тех пор, пока индек элемента в массив будет меньше его длины (узнала через сокращенную запись
                                            //  arr.Length) выводи на экран : значение элемента под индексом i и переходи к следующему
//    {
//        Console.Write(arr[i]);              
//        i++;
//        if (i < arr.Length)                 // если индекс меньше размера, после каждого значения элемента ставь ,
//        {
//            Console.Write(", ");
//        }
//    }
//    Console.Write("]");                     // в конце цикла поставь ]
//}                                           // конец метода

//PrintArray(GetArray());                     // тут объединила 2 команды в одну - можно и написать так:
                                            //int [] arr = GetArray();   // то есть в массив с именем arr - меняй как хочешь - положи результат метода GetArray 
                                            //PrintArray(arr);
