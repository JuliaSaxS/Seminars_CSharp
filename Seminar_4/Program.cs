//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++) sum += current;
    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine(result);
*/
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int GetFakt(int num)
{
    int fakt = 1;
    for(int current = 1; current <= num; current++) fakt *= current;
    return fakt;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetFakt(a);
Console.WriteLine(result);
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Number(int num)
{
    int count = 0;
    while(num != 0)
    {
        num = num / 10;
        count++;
    }   
        return count;
}    
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Number(a);
Console.WriteLine(result);
*/



//Массив


//Метод создания массива:

int[] CrateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

//Метод вывода массива:

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

//Программа:

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CrateRandomArray(length, min, max);
ShowArray(newArray);
