Console.WriteLine("HomeWork # 3");

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Task # 19 ");

Console.Write("input five-digit number ");

int number = Convert.ToInt32(Console.ReadLine());



void Palindrome(int number)
{
    if (number < 9999 || number > 99999) Console.WriteLine( "Not correct number" );
   
    else if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
    {
        Console.WriteLine( number + " it's a palindrome" );
    }
        
    else Console.WriteLine( "It's a not palindrome" );
   
}

Palindrome(number);


//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Task # 21 ");


double pantsOfPifagor3D (double x1, double x2, double y1,  double y2, double z1,  double z2)
{
    double lenghtAB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2-z1) * (z2 - z1));
    return lenghtAB;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("lenght AB is " + pantsOfPifagor3D(x1, x2, y1, y2, z1, z2));


//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Task # 23 ");

Console.WriteLine("Input number > 0: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= n)
{
    Console.Write(current * current * current + " ");
    current++;  //current = current + 1
}