//Способы инициализации переменных и массивов
//1.Конкретными значениями в коде

// int a = 5;
// int b = 7;
// int sum = q + b;

// int[] arr_int = {1, 2, 3, 4, 5, 6, 7};

// double[] doubleArr = {1.2, 4.55, 3.54, 5.6};

// 2.Генерация случайных чисел

// Random rnd = new Random();
// int size = 1000;
// int[] arr_int = new int[size];
// int i = 0;
// while(i < size)
// {
//     arr_int[i] = rnd.Next(1,10);
//     i = i +1;
// }

// i = 0;
// while(i < size)
// {
//     Console.Write($"{arr_int[i]} ");
//     i = i + 1;
// }


//3.Вввод значений с консоли:

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
    Console.WriteLine("Введите элемент массива (целое число):");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i = i + 1;
}
