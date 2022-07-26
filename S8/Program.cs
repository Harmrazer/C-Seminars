int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++ )
        newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}


void Show2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();


    }

}

Console.WriteLine("Input number rows ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number columns ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number max ");
int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2DArray(m, n, 1, 9);
// Show2DArray(myArray);


//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int [,] ChangeFirstLast(int[,] array)
// {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[0, j];
//             array[0, j] = array[array.GetLength(0)-1, j];
//             array[array.GetLength(0)-1, j] = temp;
//         }
//         return array;
    
// }
// // int[,] sArray = CreateRandom2DArray(m, n, min, max);
// Show2DArray(sArray);
// Console.WriteLine();
// Show2DArray(ChangeFirstLast(sArray));




//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя


// int [,] ReverseMatrix(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Incorrect matrix's format ");
//         return array;
//     }

//     for (int i = 0; i < array.GetLength(0) - 1; i++)
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }
//         return array;
    
// }


// int[,] myArray = CreateRandom2DArray(m, n, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// Show2DArray(ReverseMatrix(myArray));



//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.



int[,] ZeroCross(int[,] array)
{
    int a = 0;
    int b = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                a = i;
                b = j;
            }
        } 
    for (int i = 0; i < array.GetLength(0); i++)
        {
            array[a, i] = 0;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[j, b] = 0;
        }
    return array;
}

int[,] vArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(vArray);
Console.WriteLine();
Show2DArray(ZeroCross(vArray));
//Show2DArray(ReverseMatrix(vArray));