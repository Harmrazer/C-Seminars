// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

// ShowNums(5);


// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits(int n)
{
    if(n >= 10)
    {
        return n % 10 + SumOfDigits(n/10);
    }
    else return n;
}

//Console.WriteLine(SumOfDigits(1234));


// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


void ShowNumsMN(int m, int n)
{
    if(m <= n) ShowNumsMN(m, n - 1);

    Console.Write(n + " ");
}

//ShowNumsMN(5, 8);
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int DegreeOfNums(int a, int b)
{
    if (b == 1) return a;
        else if (b ==0) return 1;
            else return a * DegreeOfNums(a, b-1);
} 

// Console.WriteLine(DegreeOfNums(2, 5));

// double stepen(double a, double b)
// {
//     if (b > 0)
//     {
//         return a * stepen(a, b-1);
//     }
//     else if (b < 0)
//     {
//         return 1/a * (stepen(a, b + 1));
//     }
//     else return 1;
// }
// Console.WriteLine(stepen(2, -3));