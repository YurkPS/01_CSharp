// Рекурсия. Задача по открытию матрешки

//Условия, когда рекурсивный вызов стоит после
// void OpenMatryoshka(int size)
// {
//     Console.WriteLine($"Opening matryoshka of size {size}...");
//     // Базовый случай: самая маленькая матрёшка
//     if (size == 1)
//     {
//         Console.WriteLine("Reached the smallest matryoshka!");
//         return;
//     }
//     OpenMatryoshka(size - 1);
// }

// OpenMatryoshka(5);

// Условие, когда рекурсивный вызов стоит перед - результат от минимальной к максимальной

void OpenMatryoshka(int size)
{
    if (size == 1)
    {
       Console.WriteLine("Smallest!");
       return;
    }
    OpenMatryoshka(size - 1);
    Console.WriteLine($"Opening matryoshka of size {size}...");
}

OpenMatryoshka(5);
