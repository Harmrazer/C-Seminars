//HomeWork 7
Console.WriteLine();
Console.WriteLine("HomeWork 7");
Console.WriteLine();


//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Task # 54 ");
Console.WriteLine();

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



int[,] MinToMax(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] > array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}


Console.WriteLine("Input number rows ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number columns ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number max ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(m, n, min, max);

Show2DArray(array);
Console.WriteLine();
Show2DArray(MinToMax(array));
Console.WriteLine();






// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Task # 56 ");
Console.WriteLine();

Show2DArray(array);
Console.WriteLine();

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i2 = 0; i2 < array.GetLength(0); i2++)
{
  int temp2 = SumLineElements(array, i2);
  if (sumLine > temp2)
  {
    sumLine = temp2;
    minSumLine = i2;
  }
}

Console.WriteLine($"Min sum numbers string is {minSumLine+1}, summ is {sumLine} ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

Console.WriteLine();

// Задача 62: Заполните спирально массив 4 на 4.

Console.WriteLine("Task # 62 ");
Console.WriteLine();



int[,] spiral = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiral.GetLength(0) * spiral.GetLength(1))
{
  spiral[i, j] = temp;
  temp++;
  if (i <= j+ 1 && i + j < spiral.GetLength(1) -1)
    j++;
  else if (i < j && i + j >= spiral.GetLength(1) - 1)
    i++;
  else if (i>= j && i+j > spiral.GetLength(1) - 1)
    j--;
  else
    i--;
}

 WriteArray(spiral);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}