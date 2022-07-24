//HomeWork 7
Console.WriteLine();
Console.WriteLine("HomeWork 7");
Console.WriteLine();


//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Task # 47 ");
Console.WriteLine();

double[,] CreateDouble2Darray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++ )
        newArray[i, j] = new Random().Next(minValue, maxValue + 1) / 1.25;
    
    return newArray;
}


void ShowDouble2Darray(double[,] array)
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
double[,] myArray = CreateDouble2Darray(m, n, 1, 9);
Console.WriteLine();
ShowDouble2Darray(myArray);
Console.WriteLine();




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Task # 50 ");
Console.WriteLine();

void CheckIndex(double[,] array)
{
    Console.WriteLine("Input index row ");
    int o = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input index column ");
    int p = Convert.ToInt32(Console.ReadLine());

    if(o < 0 || o >= array.GetLength(0)) 
        Console.WriteLine("\nno elements with index row is " + o);
            else if (p < 0 || p >= array.GetLength(1)) 
            Console.WriteLine("\nno elements with index column is  " + p);
    else Console.WriteLine($"\nArray's element with index [{o},{p}] is " + array[o,p]);
}

CheckIndex(myArray);
Console.WriteLine();

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Task # 52 ");
Console.WriteLine();

int[,] CreateInt2Darray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++ )
        newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double sum=0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum+=array[i,j];
            Console.Write(sum / array.GetLength(0) + " "); 
    }
}


void Show2Darray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }   
}


int[,] TwoArray = CreateInt2Darray(5, 6, 1, 9);

Console.WriteLine();
Show2Darray(TwoArray);
Console.WriteLine();
ArithmeticMean(TwoArray);
Console.WriteLine();
