﻿// Все варианты слов из указанного алфавита

using System;
using static System.Console;

int n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[3]);