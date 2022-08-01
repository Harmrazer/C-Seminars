//Написать программу, которая выводит первое встречное слово на заданную букву из массива строк

// string FindLetter(string[] words, char cymbol)
// {
//     for (int i = 0; i < words.Length; i++ )
//         if (words[i].ToLower()[0] == Char.ToLower(cymbol)) return words[i];

//     return "Empty";
// }

//Console.WriteLine(FindLetter(names, 'a'));

//Console.WriteLine(names[1].ToUpper());




//Написать программу, 
//принимающую на вход массив строк и определяющую кол-во слов с длиной не меньше 3 символов

// string [] names = {"Denis", "Andrew", "rs", "Dmitrij", "Ivan"};

// int LongWords(string[] words)
// {   
//     int count = 0;
//     for (int i = 0; i < words.Length; i++)
//         if(words[i].Length >= 3) count++;
//         return count;
// }

// Console.WriteLine(LongWords(names));

//Написать программу, принимающую на вход два массива строк и генерирующую новый массив,
// состоящий из попарно объединенных исходных элементов

string [] names = {"Denis", "Andrew", "rs", "Dmitrij", "Ivan"};

string [] surnames = {"Popov", "Molin", "696", "lipan", "Putin"};

string [] Merge(string [] nam, string[] sur)
{
    string[] array = new string[nam.Length];

    for (int i = 0; i < nam.Length; i++)
    {
        array[i] = nam[i] + " " +sur[i];
    }
    return array;
}

void ShowArray( string[] merg)
{
    for (int i = 0; i < merg.Length; i++)
        Console.Write(merg[i] + " ");
} 


ShowArray(Merge(names,surnames));