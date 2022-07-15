
// Программа по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти 
// (x и y).
/*
void ShowRange(int quarter)
{
    if(quarter == 1)Console.WriteLine("x > 0, y > 0");
    if(quarter == 2)Console.WriteLine("x < 0, y > 0");
    if(quarter == 3)Console.WriteLine("x < 0, y < 0");
    if(quarter == 4)Console.WriteLine("x > 0, y < 0");
}
*/
/*
// Задали диапазон.

void ShowRange(int quarter)
{
    if(quarter >= 1 && quarter <= 4)
    {
    if(quarter == 1)Console.WriteLine("x > 0, y > 0");
    if(quarter == 2)Console.WriteLine("x < 0, y > 0");
    if(quarter == 3)Console.WriteLine("x < 0, y < 0");
    if(quarter == 4)Console.WriteLine("x > 0, y < 0");
    }
    else Console.WriteLine("Uncorrect input");
}
*/

// Вставили проверку. 

void ShowRange(int quarter)
{
    while(quarter < 1 || quarter > 4)
    {
        Console.Write("Uncorrect input! Try again here: ");
        quarter = Convert.ToInt32(Console.ReadLine());
    }
    if(quarter == 1)Console.WriteLine("x > 0, y > 0");
    if(quarter == 2)Console.WriteLine("x < 0, y > 0");
    if(quarter == 3)Console.WriteLine("x < 0, y < 0");
    if(quarter == 4)Console.WriteLine("x > 0, y < 0");
}

Console.Write("Input number of quarter: ");
int quarterNum = Convert.ToInt32(Console.ReadLine());

ShowRange(quarterNum);

/*
// 2. Программа принимает на вход координаты точки (X и Y), причем X != 0 и Y != 0 и 
// выдает номер четверти плоскости, в которой находится эта точка.

int Number(int x, int y)
{
    int result = 0;
    
    if(x > 0 && y > 0) result = 1;
    if(x < 0 && y > 0) result = 2;
    if(x < 0 && y < 0) result = 3;
    if(x > 0 && y < 0) result = 4;
    return result;
}

Console.Write("Введите значение координаты X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int number;
if (x != 0 && y != 0)
{
    number = Number(x, y);
    Console.WriteLine($"Точка относится к {number} четверти");
}
else Console.WriteLine("Точка находится на оси координат");
*/
/*
// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Length(double xa, double ya, double xb, double yb)
{
    double length = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
    return length;
}
Console.Write("Введите значение координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Х точки В: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки В: ");
int yb = Convert.ToInt32(Console.ReadLine());

double result = Length(xa, ya, xb, yb);
Console.WriteLine($"Расточние между точками А и В равно {result}");
*/
/*
// 4. Программа принимает на вход число (N) и выдает последовательность квадратов чисел от 1 до N.

void Numbers(double num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current*current + " "); //не current в квадрате, а число, кот.current * current.
        current ++;
    }
}

double check;
Console.Write("Введите положительное число: ");
check = Convert.ToDouble(Console.ReadLine());
if(check < 0) check = check * (-1);
Numbers(check);
*/