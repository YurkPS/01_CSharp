// СОЗДАНИЕ ФУНКЦИИ УОТОРАЯ ОБНУЛЯЕМ ЧЕТНЫЕ ЭЛЕМЕНТЫ МАССИВА

void ZeroEventElements(int[] arr)  //void - потому что, что-то возвращать у нас нет необходимости
{
    for (int i = 0; i < arr.Length; i++) //Цикл FOR для поиска четных элементов
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = {1, 2, 3, 4, 5, 6, 7 };
ZeroEventElements(array);
PrintArray(array);