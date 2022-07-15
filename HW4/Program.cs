//HomeWork 4
Console.WriteLine();
Console.WriteLine("HomeWork 4");
Console.WriteLine();

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Task # 27 ");
Console.WriteLine();

 int FindSum(int a)
{
    int dig = 0, sum = 0;
    while(a >= 1)
    {
         dig = a % 10;
         a = a / 10;
         sum = sum + dig;
        
    }
    return sum;
}

Console.WriteLine("Input number > 0 ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum is " + FindSum(num));
Console.WriteLine();


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Task # 29");
Console.WriteLine();

int[] arr = {2, 4, 7, 1, 5, 3, 6, 1};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);