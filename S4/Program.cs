
/*
void FindSum()
{
    Console.Write("Input number > 0");
    int a = Convert.ToInt32(Console.ReadLine());

    int current = 1, sum = 0;
    while(current <= a)
    {
        sum+= current;

        current++;
    }

    Console.WriteLine("Sum is " + sum);
}

FindSum();
*/
/*
 int FindSum(int a)
{
    int current = 1, sum = 0;
    while(current <= a)
    {
        sum+= current;
        current++;
    }
    return sum;
}


Console.Write("Input number > 0");
int num = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Sum is " + FindSum(num));

*/
/*

int  NumDig(int num)
{
    int i = 0;
    while(num > 0)
    {
        
        num = num/10;
        i++;
    }
    return i;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum is " + NumDig(num));
*/
/*
int  NumDig(int num)
{
    int i = 1;
    
    while(num > 1)
    {
        i = i * num;
        num--; //num = num - 1;
    }
    return i;
}


Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Answer is " + NumDig(num));

*/


Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a + " ^ " + b + " = " + Math.Pow(a, b));