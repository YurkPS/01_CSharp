// ДВА ВАРИАНТА КОДА ДЛЯ ОБРАБОТКИ МАССИВА ИЗ ЦЕЛЫХ ЧИСЕЛ

//int n = 10;                         //создание массива
//int [] arr = new int [n];           //создание массива    
//int i = 0;                          //создание массива
// while (i < n)                       //заполнениe массива (FillArray[arr])
// {
//     arr[i] = i + 1;
// }                                   //заполнение массива (FillArray[arr])
// i = 0;
// while (i < n)                       //Вывод (PrintArray[arr]) 
// {
//     Console.Write($"{arr[i]} ");
// }                                   //Вывод (PrintArray[arr])
// i = 0;
// sum = 0;
// while (i < n)                       //Сумма элементов
// {
//     sum = sum + arr[i];
// }                                   //Сумма элементов
// i = 0;
// product = 1;
// while (i < n)                       //Произведение элементов
// {
//     product = product * arr[i];
// }                                   //Произвеение элементов
// Console.WriteLine(sum);
// Console.WriteLine(product);


int n = 10;                         //создание массива
int [] arr = new int [n];           //создание массива
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine(sum);
Console.WriteLine(product);