

//HomeWork 5
Console.WriteLine();
Console.WriteLine("HomeWork 5");
Console.WriteLine();

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Task # 34 ");
Console.WriteLine();

/*
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
Console.WriteLine(FindEven(array));


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
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Task # 38 ");
Console.WriteLine();



//double num = new Random().Next(1, 10); 
//+ new Random().NextDouble();

//Console.WriteLine(num);
/*
void ShowDoubleArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] * 0.24 + " ");

    Console.WriteLine();  
}
*/

int DoubleMin(int[] array)
{
    double min = array[0];
    for(double i =0; i < array.Length; i++)
        if(min > array[i] ) min = arrai[i];
       
    return min;    
}

/*
int[] Varray = CreateRandomArray(5, 1, 30);
ShowDoubleArray(Varray);
*/
//Console.WriteLine("min " + DoubleMinMax(Sarray));


  double[] arr = {2, 4, 7, 1, 5, 3, 6, 1};
    void PrintArray(double[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]*0.24} ");
    }
    Console.WriteLine();
}

PrintArray(arr);


double num = new Random().Next(1, 10) + new Random().NextDouble() * 5;

Console.WriteLine(num);


/*
double [] CreateArray(double size, double min, double max)

{   
    double[] array = new double[size];

    for(double i = 0; i < size; i++)
    
        array[i] = new Random().NextDouble(min, max + 1);  // если в цикле for 1 действие, то {} можно не ставить

        return array;
} 
*/





