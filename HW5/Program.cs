

//HomeWork 5
Console.WriteLine();
Console.WriteLine("HomeWork 5");
Console.WriteLine();

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Task # 34 ");
Console.WriteLine();


int [] CreateRandomArray(int size, int min, int max ) 
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(min, max + 1);  // если в цикле for 1 действие, то {} можно не ставить

        return array;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();  
}


int FindEven(int[] array)
{
    int quantity = 0;
    for(int i =0; i < array.Length; i++)
        if(array[i] % 2 ==0) 
        quantity++;

    return quantity;    
}

int[] array = CreateRandomArray(7, 1, 9);
ShowArray(array);
Console.WriteLine("Even numbers is " + FindEven(array));
Console.WriteLine();


//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Task # 36 ");
Console.WriteLine();



int FindNotEvenSum(int[] array)
{
    int sum = 0;
    for(int i =0; i < array.Length; i++)
        if(i % 2 == 0 ) sum += array[i];  //индексы элементов расположены как 012345....
                                          //соответственно если искать четные элементы индексов получил нечетные позиции чисел 
                                          // i = 0 при делении на 2 тоже = 0

    return sum;    
}

int[] Sarray = CreateRandomArray(7, 1, 9);
ShowArray(Sarray);

Console.WriteLine("Summ of numbers on not even positions is: " + FindNotEvenSum(Sarray));
Console.WriteLine();

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Task # 38 ");
Console.WriteLine();


double[] DoubleArray = new double[10];
  for (int i = 0; i < DoubleArray.Length; i++ )
  {
    DoubleArray[i] = new Random().Next(1, 10) * 1.24;
    Console.Write(DoubleArray[i] + " ");
  }
Console.WriteLine();

double max = DoubleArray[0];
double min = DoubleArray[0];

  for (int i = 1; i < DoubleArray.Length; i++)
  {
    if (max < DoubleArray[i])
    {
      max = DoubleArray[i];
    }
        if (min > DoubleArray[i])
    {
      min = DoubleArray[i];
    }
  }

  double diff = max - min;

  Console.WriteLine($"max number is ({max}), min number is ({min}), differens is {diff}");



