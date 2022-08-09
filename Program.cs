// Создание массива
string[] CreateArrayWords()
{
    int stringlen = new Random().Next(3, 10);
    return new string[stringlen];
}
// Заполнение массива
string[] fillingArrayWords(string[] arrayWords)
{
    int len = arrayWords.Length;
    string word = "";
    int randomValue;
    char letter;
    Random random = new Random();

    for (int j = 0; j < len; j++)
    {
        for (int i = 0; i < random.Next(1, 10); i++)
        {
            randomValue = random.Next(1, 65);
            letter = Convert.ToChar(randomValue + 65);
            word += letter;
        }
        arrayWords[j] = word;
        word = "";
    }
    return arrayWords;
}
// алгоритм решения к задаче
string[] NewStrArray(string[] array)
{
    string[] arrayWords = new string[array.Length];//Array.Empty<string>();
    int countSymbol = 3; // магическое число по условию задачи
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countSymbol)
        {
            arrayWords[k] = array[i];
            k++;
        }
    }
    return arrayWords;
}

string[] create = CreateArrayWords();
string[] array = fillingArrayWords(create);
Console.Write($"Массив случайных строк: [{string.Join(' ', array)}]");
Console.WriteLine();
string[] newStrArray = NewStrArray(array);
Console.Write($"Массив строк длина которых меньше либо равна 3 символа: [{string.Join(' ', newStrArray)}]");



/*
 * int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
 */