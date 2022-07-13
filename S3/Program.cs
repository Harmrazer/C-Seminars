/*

int FindQuart(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return -1;
}

Console.Write("Input X coord: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coord: ");
int y = Convert.ToInt32(Console.ReadLine());

int quart = FindQuart(x, y);





if(quart == -1)

    Console.WriteLine("Point on the axes!");
else 

    Console.WriteLine(" Number of quart for out points is " + quart);

*/
Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= n)
{
    Console.Write(current * current + " ");
    current++;  //current = current + 1
}


