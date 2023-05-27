// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int [] CreateRandomArray (int size, int minVal, int maxVal) 
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1); 
    return newArray;
}

void ShowArray (int [] array1) 
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write (array1[i]+ " ");
    Console.WriteLine();
}

int FindNum (int [] array)
{
    int numChetn = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            numChetn = numChetn + 1;
    Console.WriteLine($"Count of elements is {numChetn}");
    return numChetn;
    
}

int sizeStart = 10; 
int minPossibleVal = 100; 
int maxPossibleVal = 999;

int [] arrayStart = CreateRandomArray(sizeStart, minPossibleVal, maxPossibleVal); 
ShowArray(arrayStart); 
FindNum (arrayStart);

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int [] CreateRandomArray (int size, int minVal, int maxVal) 
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1); 
    return newArray;
}

void ShowArray (int [] array1) 
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write (array1[i]+ " ");
    Console.WriteLine();
}

int FindSum (int [] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            summ += array[i];
    Console.WriteLine($"Summ of elements is {summ}");
    return summ;    
}

int sizeStart = 5; 
int minPossibleVal = -100; 
int maxPossibleVal = 100;

int [] arrayStart = CreateRandomArray(sizeStart, minPossibleVal, maxPossibleVal); 
ShowArray(arrayStart); 
FindSum (arrayStart);

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
double [] CreateRandomArray (int size, int minVal, int maxVal)
{
    double [] newArray = new double [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal) + new Random().NextDouble(); 
    return newArray;
}

void ShowArray (double [] array1) 
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write (array1[i]+ " ");
    Console.WriteLine();
}

double FindMax (double [] array)
{
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > maxNum)
            maxNum = array[i];
    return maxNum;
}

double FindMin (double [] array)
{
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < minNum)
            minNum = array[i];
    return minNum;
}

int sizeStart = 5; 
int minPossibleVal = 0; 
int maxPossibleVal = 2;

double [] arrayStart = CreateRandomArray(sizeStart, minPossibleVal, maxPossibleVal); 
ShowArray(arrayStart);
double maxNum = FindMax (arrayStart);
double minNum = FindMin (arrayStart);

double delta = maxNum - minNum;
Console.WriteLine($"Delta of max and min elements is {delta}");

*/

