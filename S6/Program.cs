


string ChangeNumber(int number)
{
    string result = string.Empty;

    while(number >= 1)
    {
        result = number  % 2 + result;
        number /= 2; //аналогично number = number / 2;

    }
    return result;
}

Console.WriteLine(ChangeNumber(10));
//перевернуть одномерный массив
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

void ReturnArray(int[] array)
{
    for (int i = array.Length -1; i >= 0; i--)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}

int[] array = CreateRandomArray(7, 1, 9);
ShowArray(array);
ReturnArray(array);


// вариант с семинара

/*
int[] ReversArr(int[] arr)
{
    int j = arr.Lenght - 1;
    int temp = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        j--;

    }
    return arr;
}
    */



//3 числа и проверить существовоание треугольника с такими сторонами


//cherry on the cake by Pavel

//bool CheckTriangle(int a, int b, int c) 
//return (a < b + c) && (b < a + c) && (c < a + b);

bool CheckTriangle(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))
    {
        Console.WriteLine("triangle exist ");
        return true;
        
    }
    Console.WriteLine("triangle do not exist ");
    return false;
    
    
}

Console.Write("input first side of triangle > 0: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input second side of triangle > 0: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("input third side of triangle > 0: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(a,b,c));




//первые n чисел фибоначчи вывести

int[] Fibonacci(int f1, int f2, int n)
{
    int[] array = new int[n];
    array[0] = f1;
    array[1] = f2;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i -2] + array[i -1];
    }
    return array;
}

Console.Write("input first number of Fibonacci: ");
int fib1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number of Fibonacci: ");
int fib2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input lenght of Fibonacci: ");
int N = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibonacci(fib1, fib2, N));