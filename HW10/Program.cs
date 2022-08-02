//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.


// int FindVowel(string[] words, char[] vowel)
// {       int count = 0;
//     for (int i = 0; i < words.Length; i++ )
//         for(int j =0; j < vowel.Length; j++)
//     {
//             if (words[i][0] == vowel[j]) count += 1;  
//     }

//     return count;
// }

// char[] vowel = {'a', 'e', 'i', 'o', 'u', 'y'};

// string[] words = {"aqua", "ring", "clock", "use", "lock"};
// Console.WriteLine("words begoning with vowel letter is " + FindVowel(words, vowel));


//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

// string [] names = {"Denis", "Popov", "Andrew", "Molin", "rs", "696", "Dmitrij", "lipan", "Ivan", "Putin"};



// string [] Merge(string [] nam)
// {
//     string[] array = new string[nam.Length];

//     for (int i = 0; i < nam.Length; i++)
//     {
//         array[i] = nam[i] + " " + nam[i + 1];
//     }
//     return array;
// }

// void ShowArray( string[] merg)
// {
//     for (int i = 0; i < merg.Length; i++)
//         Console.Write(merg[i] + " ");
// } 


// ShowArray(Merge(names));