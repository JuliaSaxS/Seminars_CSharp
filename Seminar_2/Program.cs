// Задача на выделение из случайного трехзначного числа первой и последней цифры, и преобразование результата в двузначное число.
/*
int CutNumber(int number)
{
    return 10 * (number / 100) + number % 10;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of a number {randNumber} is {newNumber}.");
*/

// Задача на определение четности числа (истина или ложь).
/*
bool IsEven(int num)
{
    if(num % 2 == 0)
        return true;
    else
        return false;
}
*/

// Запись дополнительного условия для решения.

// логическое и:
/*
int a = 5;
if(a > 0 && a % 2 == 0)
{

}
*/

// логическое или:
/*
int a = 5;
if(a > 0 || a % 2 == 0)
{

}
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxDigit(int num)

{int num1 = num / 10;
int num2 = num % 10;

if(num1 == num2)
{
    return -1;
}
else
    if(num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

int randNumber = new Random().Next(10, 100);

Console.WriteLine($"The largest digit of the number {randNumber} is {MaxDigit(randNumber)}.");
*/

// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому.
/*
bool Multiple(int num1, int num2)
{
    if(num2 % num1 == 0) return true;
    else return false;
}

Console.Write("Input the first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number {num2} is a multiple of the number {num1} -  it's {Multiple(num1, num2)}.");
*/

//Напишите программу, которая принимает на вход два числа  проверяет, является ли одно число квадратом другого.

bool Multiple(int num1, int num2)
{
    if(num2 == num1 * num1 || num1 == num2 * num2) return true;
    else return false;
}

Console.Write("Input the first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"One number is equal to the squared of the other -  it's {Multiple(num1, num2)}.");