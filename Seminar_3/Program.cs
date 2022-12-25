// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void GetDiapazone(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write(" Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int GetFunk(int xPos, int yPos)
{
    if(xPos > 0 && yPos > 0) return 1;
    else if(xPos < 0 && yPos > 0) return 2;
    else if(xPos < 0 && yPos < 0) return 3;
    else if(xPos > 0 && yPos < 0) return 4;
    else return 0;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(GetFunk(x, y) == 0) Console.WriteLine($"The point with the x = {x} and y = {y} coordinates is located on the axes.");

else Console.WriteLine($"The point with x = {x} and y = {y} coordinates is located in {GetFunk(x, y)} quadrant.");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void QuadNum (int num)
{
    int current = 1;
    while (current <= num)
        {
            Math.Pow(current, 2);
            Console.Write($"{Math.Pow(current, 2)}, ");
            current++;
        }
}
Console.Write("Input a number: ");
int x = Convert.ToInt32(Console.ReadLine());

QuadNum(x);
*/
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double TwoPoints(double xPos1, double yPos1, double xPos2, double yPos2)
{
    return Math.Sqrt(Math.Pow(xPos1 - xPos2, 2) + Math.Pow(yPos1 - yPos2, 2));
}

Console.Write("Input X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(TwoPoints(x1, y1, x2, y2));