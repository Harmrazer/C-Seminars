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


Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = n * (-1);

while(current <= n)
{
    Console.Write(current + " ");
    current++;  //current = current + 1
}


