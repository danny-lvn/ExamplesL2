﻿using System;

// Вид 1 (не принимают, не возвращают)
/*void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1(); // Так вызываются


// Вид 2 (принимают, не возвращают)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 3, msg: "Новый текст");


// Вид 3 (не принимают, возвращают)
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);
*/

// Вид 4 (принимают, возвращают)
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "AbCd");
Console.WriteLine(res);*/

/*string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);*/

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}