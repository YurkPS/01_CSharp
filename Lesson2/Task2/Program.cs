﻿// Создать массив и заполнить его целыми
// числами от 1 до N (N – произвольное
// натуральное число). Вывести элементы
// массива на экран.
// Этапы решения задачи
// 1. Ввод N
// 2. Создание массива
// 3. Заполнение массива
// 4. Вывод массива на экран

int N = 10;

int[] arr = new int[N];
int i = 0;

while(i < N)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //console.Write(" ");
    //Эти две строки можно заменить одной строкой, одной командой
    Console.Write($"{arr[i]}");
    i = i + 1;
}