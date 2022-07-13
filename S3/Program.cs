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
//При вводе номера четверти указать интервалы x и y в данной четверти
/*
void quarters(int n)
{
    if (n == 1) Console.WriteLine("In first quart x > 0, y > 0");
    if (n == 2) Console.WriteLine("In second quart x < 0, y > 0");
    if (n == 3) Console.WriteLine("In third quart x < 0, y < 0");
    if (n == 4) Console.WriteLine("In fourth quart x > 0, y < 0");
    if (n < 1 || n > 4) Console.WriteLine("Wrong number quarter");

}
Console.WriteLine("Input number quarter ");
int n = Convert.ToInt32(Console.ReadLine());
quarters(n);

*/
// Задать число N и найти квадраты чисел от 1 до N
/*

Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= n)
{
    Console.Write(current * current + " ");
    current++;  //current = current + 1
}
*/

//найти расстояние между двумя точками в двухмерном пространстве
/*
  double PantsOfPifagor(double xa, double ya, double xb, double yb)
 {
    double LenghtAB = Math.Sqrt((xb - xa) * (xb - xa)  +  (yb - ya) * (yb - ya));
    return LenghtAB;

 }
Console.WriteLine("Input xa ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input xb ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input ya ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input yb ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("AB is: " + PantsOfPifagor(xa, ya, xb, yb));

*/





