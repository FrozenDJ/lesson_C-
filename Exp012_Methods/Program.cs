// Type 1
void Method1()
{
    Console.WriteLine("Create by ... ");
}
// Method1();

// Type 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Text... ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine();
        i++;
    }
}
// Method21(msg: "Text", count: 4);

// Type 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// Type 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "abir");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "xxx");
// Console.WriteLine(res);

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// =====Работа стекстом=====
// Дан текст. В тексте нужно заменить все пробелы чёррточками,
// маленькие буквы "к" заменить большими "К",
// а большие буквы "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);