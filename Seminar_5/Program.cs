// Разбор домашнего задания. 
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CrateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CrateArray(length);
ShowArray(newArray);
*/

// Написать программу, которая определяет сумму отрицательных элементов в массиве.
/*
int[] CrateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) sum += array[i];
    return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CrateRandomArray(length, min, max);
ShowArray(newArray);

int result = GetSumOfNegatives(newArray);
Console.WriteLine("Sum of negatives of this array is " + result);
*/

// Написать программу, заменяющую положительные элементы массива на отрицательные и наоборот.

int[] CrateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();    
}

int[] GetNegatives(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        array[i] = -array[i];
    }
    return array;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CrateRandomArray(length, min, max);
ShowArray(array);
int[] newArray = GetNegatives(array);
ShowArray(newArray);


// Написать программу, определяющую, присутствует ли заданное число в массиве.

bool IsNumberInArray(int[] array, int numb)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == numb) return true;
    return false;
}


// Задать массив из n элементов, определить кол-во элементов, принадлежащих отрезку [a,b].

int NumbersInArray(int[] array, int a, int b)
{
    if(a > b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && array[i] <= b) counter ++;
    }
    return counter;
}

int[] testArray = CrateRandomArray(21, -11, 11);
ShowArray(testArray);
ShowArray(GetNegatives(testArray));

Console.WriteLine(IsNumberInArray(testArray, 0));
Console.WriteLine(NumbersInArray(testArray, -5, 5));






