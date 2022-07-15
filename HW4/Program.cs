//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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
