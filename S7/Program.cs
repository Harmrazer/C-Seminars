
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
// Console.WriteLine("Input number rows ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number columns ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2DArray(m, n, 1, 9);
// Show2DArray(myArray);


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
// Выведите полученный массив на экран.

int[,] NotRandomArray(int m, int n, int minValue, int maxValue)
{   
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j =0; j < n; j++)
        newArray[i, j] = i + j;
    return newArray;
}


// Console.WriteLine("Input number rows ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number columns ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = NotRandomArray(m, n, 1, 9);
// Show2DArray(myArray);





// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] SquareEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2 )
        array[i, j] *= array[i, j];
    
    return array;
}

// Console.WriteLine("Input number rows ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number columns ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = NotRandomArray(m, n, 1, 9);
// Show2DArray(myArray);
// Console.WriteLine();
// Show2DArray(SquareEven(myArray));

// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int MainDiag(int[,] array)
{   
    int sum = 0;
    if(array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,i];
        }
    }
    
        
    
    return sum;
}

Console.WriteLine("Input number rows ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number columns ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = NotRandomArray(m, n, 1, 9);
Show2DArray(myArray);
Console.WriteLine();
Console.WriteLine(MainDiag(myArray));