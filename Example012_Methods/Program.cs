// Вид 1  Метод ни чего не возвращает.

void Method1();
{
    Console.WriteLine();
}
Method1();

// Вид 2  Может принимать
// какие либо аргументы. Метод ни чего не возвращает.

void Method2(string msg);
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст сообщения", count: 4);
Method21(count: 4, msg: "Новый текст");


// Вид 3 Метод может что-то возвращать, но не принимать ни
// какич аргументов.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Вид 4   Может принимать какие либо данные.
// И возвращает какие либо аргументы.

int Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result += text;
        i++;
    }
    return result;
}


string res = Method4(10, "asdf");
Console.WriteLine(res);

// С циклом for

int Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count, i++;) 
    {
        result += text;
    }
    return result;
}


string res = Method4(10, "z");
Console.WriteLine(res);
