string[] CreateArrayWords()
{
    int stringlen = new Random().Next(3, 10);
    return new string[stringlen];
}
string[] ArrayWords(string[] arrayWords)
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
            randomValue = random.Next(1, 896);
            letter = Convert.ToChar(randomValue + 65);
            word += letter;
        }
        arrayWords[j] = word;
        word = "";
    }
    return arrayWords;
}

string[] create = CreateArrayWords();
string[] array = ArrayWords(create);
Console.Write($"Массив случайных строк: {string.Join(' ', array)}");