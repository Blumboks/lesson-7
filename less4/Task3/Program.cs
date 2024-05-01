string GetLetters(string s)
{
    string letters = "";
    foreach(char e in S)
    {
        if(char.IsAsciiLetter(e) == true)// метод для проверки буквенности
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLetters(str);
System.Console.WriteLine(result);