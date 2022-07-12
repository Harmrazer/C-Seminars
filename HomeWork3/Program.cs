Console.WriteLine("HomeWork # 3");

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Task # 19 ");

Console.Write("input five-digit number ");
int number = Convert.ToInt32(Console.ReadLine());


void Palindrome(int number)
{
    int a = number / 10000;
    int b = number % 10;
    int c = number / 1000;
    int d = (number % 100) / 10;
    if (a == b || c == d)
    {
        Console.WriteLine( number + " it's a palindrome" );
    }
    
    
    else Console.WriteLine( "It's a not palindrome" );
   
}

Palindrome(number);