// Дано N гирь с разным весом в случайном
// порядке. Определить вес самой тяжелой
// гири.



//Первое решение
// int N = 10;

// int[] array = {1,13,6,7,8,3,4,9,15,8};
// int i = 0;
// int max = array[0];

// while(i < N)
// {
//     if(array[i] > max)
//     {
//         max = array[i];
//     }
//     i = i + 1;
// }
// Console.WriteLine(max);

// Решение с помощью цикла FOR и FOREACH

max = array[0];
for(int i = 0; i < n; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }    
}
Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if(e > max)
    {
        max = e;
    }    
}
Console.WriteLine(max);