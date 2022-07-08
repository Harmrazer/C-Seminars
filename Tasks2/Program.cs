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
