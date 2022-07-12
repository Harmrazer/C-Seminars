/*
int FindFirstLast()
{
      int rand = new Random().Next(100, 1000);
      Console.WriteLine("Current random number is " + rand);

      int first = rand / 100;
      int last = rand % 10;

      int FirstLast = (first * 10) + last;
      return FirstLast;
}

int fl = FindFirstLast();
Console.WriteLine("only first and last numbers is " + fl);


void MultOfNums(int n1, int n2)
{
    int sum = n2 % n1;
    if (sum == 0)
    {
        Console.WriteLine( n2 + " кратно " + n1);
    }
    else
    {
        Console.WriteLine( n2 + " не кратно " + n1 + ", остаток " + sum);
    }
   
}

int number1 = 5;
int number2 = 49;


MultOfNums(number1, number2);




void MultOneNum(int n)
{
    int sum = n % (7 * 23);
    if (sum == 0)
    {
        Console.WriteLine( n + " yes ");
    }
    else
    {
        Console.WriteLine( n + " no " );
    }
   
}

int number = 322;



MultOneNum(number);

*/

//HomeWork#2

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("HomeWork # 2");
Console.WriteLine("Task # 10 ");

int FindSecondNumber()
{
      int rand = new Random().Next(100, 1000);
      Console.WriteLine("Current random number is " + rand);

      int second = (rand % 100) / 10;
   
      return second;
}

int sec = FindSecondNumber();
Console.WriteLine("only second numbers is " + sec);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Task # 13 ");


Console.Write("Input number ");
int n = Convert.ToInt32(Console.ReadLine());
string nstr = Convert.ToString(n);

if (nstr.Length > 2){
  Console.WriteLine("Third number is  " + nstr[2]);
}
else {
  Console.WriteLine("No third number");
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Task # 15 ");



Console.Write("input number a week's day ");
int day = Convert.ToInt32(Console.ReadLine());


void DayOfWeek(int day)
{
    
    if (day == 6 || day == 7)
    {
        Console.WriteLine( day + " it's a weekend " );
    }
    else if (day < 1 || day > 7)
    {
        Console.WriteLine( " Entered number not correct" );
    }
    
    else Console.WriteLine( "It's a working day" );
   
}
DayOfWeek(day);