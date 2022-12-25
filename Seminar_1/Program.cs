//int a = 5;
//double b = 23.6;
//bool c = true;
//string d = "World jmndogu je;kasdakdjh";
//char e = 'd';

//int a = 5;
//Console.WriteLine("a");

//Console.Write("Input a number: ");
//int number= Convert.ToInt32(Console.ReadLine());

// Seminar 1.

// Task 1. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

// Task 2. Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++; // current = current + 1, current += 1
}
*/

// 25 / 10 = 2 неполное частное
// 25 % 10 = 5 остаток деления

/* 
32465 / 10 = 3246
32465 / 100 = 324
32465 / 1000 = 32
32465 / 10000 = 3

32465 % 10 = 5
32465 % 100 = 65
32465 % 1000 = 465 
32465 % 10000 = 2465

354861 % 10000 / 100 = 48
354861 / 100 % 100 = 48
*/
