//Назовем число интересным, если его сумма цифр чётная.
//Создать двумерный массив, состоящий из целых чисел
//Вывести на экран интересные элементы массива


int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1001); //Диапазон расширим до 1000
        }
    }
    return matrix; //Добавляется в конце тела функции. Вернем созданный и заполненный массив
}

int[,] matrix = CreateMatrix(3, 4); //Создаем двумерный массив для дальнейшей работы
ShowMatrix(matrix);
Console.WriteLine();

foreach (int e in matrix)
{
    if(IsInteresting(e) == true) //Проверяет каждый элемент мартрицы на интересность
    {
        Console.Write($"{e} "); //Выводит элемент на экран, при условии TRUE
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0) //Цикл работает только пока число больше 0
    {
        sum += value % 10; //Получаем разряд единиц числа
        value /=10;        //Получаем следующую цифру, каждый раз разделяя число на 10
    }
    return sum; //Возвращаем сумму
}

void ShowMatrix(int[,] matrix)
{ //Теперь оформляем ВЫВОД
    for(int i = 0; i < matrix.GetLength(0); i++) //Это строки
    {
        for(int j = 0; j < matrix.GetLength(1); j++)  //Это столбцы
        Console.Write(matrix[i, j] + "\t"); //Табуляция для того, чтобы столбцы были ровными
        Console.WriteLine(); //Переходим на новую строку, когда закончился цикл FOR 
    }        

}
//ShowMatrix(matrix);
Console.WriteLine();