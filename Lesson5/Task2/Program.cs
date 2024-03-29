﻿// Вычислить факториал от натурального числа N
// N! = 1*2*...*N
// 3! = 1*2*3 = 6
// 5! = 1*2*3*4*5* = 120
// 10! = 3 628 800
//
// 1! = 1
// 0! = 1

// N! = N * (N-1)!
// 3! = 3 * 2!
// 2! = 2 * 1!
// 1! = 1

// Нижеприведенное решение по факториалу применяется 
// только с обучающей целью. Факториал решается с помощью цикла

int Fact(int n)
{
    if(n == 1 || n == 0)
    {
        Console.WriteLine($"Stop requrson: n={n}"); //Отладочная строка
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}

Console.Write(Fact(5));

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (до следующей точки)
