int [] CreateRandomArray(int size, int min, int max ) 
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(min, max + 1);  // если в цикле for 1 действие, то {} можно не ставить

        return array;

}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();  
}


int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i =0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];

    return sum;    
}


bool IsElementHere(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}
int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);


if(IsElementHere(myArray, 9)) Console.WriteLine("element exists");
else Console.WriteLine("There is no element");

/*

int[] Opposite(int[] aarray)
{
    for(int i = 0; i < aarray.Length; i++ )
        aarray[i] = aarray[i] * (-1);
    return aarray;
}

int[] tarray = CreateRandomArray(12, -9, 9);

ShowArray(tarray);
ShowArray(Opposite(tarray));


*/
/*

int NumOfHundred(int[] array)
{
    int hund = 0;
    for(int i = 0; i < array.Length; i++ )
        if (array[i] > 10 && array[i] <= 99)
        hund++;

    return hund;
}

int[] tarray = CreateRandomArray(20, 1, 200);

ShowArray(tarray);
Console.WriteLine(NumOfHundred(tarray));

*/


double num = new Random().Next(1, 10) + new Random().NextDouble();

Console.WriteLine(num);