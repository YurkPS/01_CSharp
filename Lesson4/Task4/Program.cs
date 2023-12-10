//Первый способ создания строки:
//string str = "Hello world!";
//Console.Write(str[0]);

//Второй способ создания строки:
//char[] ch_array = { 'w', 'o', 'r', 'l', 'd'};
//string s2 = new string(ch_array);

//string s3 = new String('a', 6); /Результатом будет строка "aaaaaa"


//Задача 3. Счистать с консоли строку, состоящую из цифр и
//латинских букв.
//Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromStr(string s) //Функция будет извлекать буквы из строки
{
    string letters = ""; //Переменная letters будет хранить извлеенные из строки буквы
    foreach(char e in s) //foreach можно, т.к. изменять строки не допускается.
    {
        if(char.IsAsciiLetter(e) == true) //IsAsciiLetter примет на вход символ и сообщит, буквенный ли он.
        {
            letters = letters + e; //Здесь можно использование сложение. При буквенном выражениях буквы соединяются.
        }
    }
    return letters;
}

string str = Console.ReadLine();
string letters = GetLettersFromStr(str);
Console.WriteLine(letters);