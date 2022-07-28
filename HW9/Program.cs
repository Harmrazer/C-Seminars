//HomeWork 9
Console.WriteLine();
Console.WriteLine("HomeWork 9");
Console.WriteLine();

// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

Console.WriteLine("Task # 64 ");
Console.WriteLine();

int NumsOfDigits(int n)
{
    if(n > 9)
    {
        return 1 + NumsOfDigits(n/10);
    }
        else return 1;
}

Console.WriteLine("Input number N ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number of digits from {N} is " + NumsOfDigits(N));
Console.WriteLine();


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Task # 66 ");
Console.WriteLine();

int SumNumsMN(int m, int n)
{
    if(m < n) 

    return m + SumNumsMN(m + 1 , n);

    else return m;
}

Console.WriteLine("Input number M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits from {m} to {n} is " + SumNumsMN(m,n));