/*int n1, n2, quad;
Console.Write("Input first number: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
n2 = Convert.ToInt32(Console.ReadLine());
quad = n2*n2;
if (quad ==  n1)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*int n1, quad;
Console.Write("Input first number: ");
n1 = Convert.ToInt32(Console.ReadLine());
quad = n1*n1;
Console.WriteLine("Quad number is: " + quad);
*/

/*int n1;
Console.WriteLine("Input number day of week: ");

n1 = Convert.ToInt32(Console.ReadLine());


    if(n1 == 1)
{
    Console.WriteLine("Monday ");
}

else 
    if(n1 == 2)
{
    Console.WriteLine("Tuesday");
}

else
    if(n1 == 3)
{
    Console.WriteLine("Wensday ");
}

else 
    if(n1 == 4)
{
    Console.WriteLine("Thurday ");
}

else 
    if(n1 == 5)
{
    Console.WriteLine("Friday ");
}

else
    if(n1 == 6)
{
    Console.WriteLine("Saturday ");
}

else 
    if(n1 == 7)
{
    Console.WriteLine("Sunday ");
}

else

{
    Console.WriteLine("You stuped?");
    }

*/


/*int n2, result;

Console.WriteLine("Input 3-number: ");

n2 = Convert.ToInt32(Console.ReadLine());

result = n2 % 10;

Console.WriteLine(result);
*/


/* 
Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = n * (-1);

while(current <= n)
{
    Console.Write(current + " ");
    current++;  //current = current + 1
}
*/

//Homework #1 

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("HomeWork # 1");
Console.WriteLine("Task # 2 ");

int a1, b1, max;

Console.Write("Input first number: ");

a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");

b1 = Convert.ToInt32(Console.ReadLine());


if (a1 > b1)
{
    max = a1;
}

else
{
    max = b1;
}

Console.WriteLine("max = " + max);


/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Task # 4 ");

int a2, b2, c, max2;

Console.Write("Input first number: ");

a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");

b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");

c = Convert.ToInt32(Console.ReadLine());

max2 = a2;

if (b2 > max2) max2 = b2;

if (c > max2) max2 = c;


Console.WriteLine("max = " + max2);


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/


Console.WriteLine("Task # 6 ");

int a3;

Console.WriteLine("Input number");


a3 = Convert.ToInt32(Console.ReadLine());


if (a3 % 2 == 0)
{
    Console.WriteLine(a3 + " is even");
}

else
{
    Console.WriteLine(a3 + " is uneven");
}

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine(" Task 8");

Console.WriteLine("Input a positive number");

int N = Convert.ToInt32(Console.ReadLine());
int even = 2; //на выходе же показываем четные числа начиная с 1, значит следующкее ближайшее четное число 2.

while(even <= N)

    {
    Console.Write(even + " ");
    even = even + 2;
    }



