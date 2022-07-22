//HomeWork 6
Console.WriteLine();
Console.WriteLine("HomeWork 6");
Console.WriteLine();


// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Task # 41 ");
Console.WriteLine();


Console.WriteLine("Input lenght M ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Marray = new int[m];

void InputM(int m)
{
    for (int i = 0; i < m; i++)
  {
    Console.Write($"Input number {i+1} ");
    Marray[i] = Convert.ToInt32(Console.ReadLine());
  }
}



int PositiveNum(int[] Marray)
{
  int count = 0;
  for (int i = 0; i < Marray.Length; i++)
  {
    if(Marray[i] > 0 ) count += 1; 
  }
  return count;
}

InputM(m);

Console.WriteLine($"Positive numbers is : {PositiveNum(Marray)} ");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Task # 43 ");
Console.WriteLine();

// найдем х и y в точке пересечения прямых
// y = k1*x + b1 так и оставляем y = k1*x + b1
// y = k2*x + b2 выведем х => k1*x + b1 = k2*x + b2 => x = (b2 - b1) / (k1 - k2)

Console.WriteLine("Two straight lines are given by the equations, set the coordinates k1, b1, k2, b2 ");

Console.Write("input k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x) + b1;


void Output (double k1, double k2, double b1, double b2)
{
    if (k1 == k2 && b1 == b2) 
  {
    Console.Write("straight lines match");
  }
  else if (k1 == k2 && b1 != b2) 
  {
    Console.Write("straight lines are parallel");
  }
  else 
  { 

   Console.Write("Crosspoint have coordinats: x = "+ x + "," + "y = " + y); 
  }
} 
    

Output(k1,k2,b1,b2);

