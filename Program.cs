﻿// Задача 1
// Вычислить значение формулы: (a * b)/(c + d), где
// a, b, c, d, - некоторые целый числа. 
// Решение оформить в виде функции.

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denomenator = c + d;
//     double result = numenator / denomenator;
//     return result;
// }

// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);
//------------------------------------------------//
// Задача 2
// Вывод на экран квадратов числа от 1 до N.
// P.S Это решение онли для нахождения квадрата числа))
// int Square(int N)  // Вощвращаемае значение функция
// {
//     int result = N * N;
//     return result;
// }

// int result = Square(7);
// Console.WriteLine(result);
// Правильное решения, исходя из условия )
void PrintSquares(int limit)  // Невозвращаемае значения функция
{
    int i = 1; //  переменная "Счётчик"
    while (i <= limit) //цикл пока Счетчик меньше limit, исходя из условия задачи
    {
        Console.Write($"{i * i} ");
        i = i + 1; // След. значения счетчика (от 1 до limit), можно написать "i++"
    }
}

PrintSquares(5);   // 3 раза вызываем функцию(как в начале лекции в задачи без функций)
PrintSquares(10);  //
PrintSquares(15);  //