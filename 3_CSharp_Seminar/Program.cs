
// Программа по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти 
// (x и y).

void ShowDiapason(int quart)
{
    if(quart == 1)Console.WriteLina("x > 0, y > 0");
    if(quart == 2)Console.WriteLina("x > 0, y > 0");
    if(quart == 3)Console.WriteLina("x > 0, y > 0");
    if(quart == 4)Console.WriteLina("x > 0, y > 0");
}

// Задали диапазон.

void ShowDiapason(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
    if(quart == 1)Console.WriteLine("x > 0, y > 0");
    if(quart == 2)Console.WriteLine("x > 0, y > 0");
    if(quart == 3)Console.WriteLine("x > 0, y > 0");
    if(quart == 4)Console.WriteLine("x > 0, y > 0");
    }
    else Console.WriteLine("Uncorrect input");
}

// Вставили проверку. Надо дописать.

void ShowDiapason(int quart)
{
    while(quart < 1 || quart > 4)
    {
        Console.Write("Uncorrect input! Try again here: ");
        quart = ConvertюToInt32(Console.ReadLine());
    }
    if(quart == 1)Console.WriteLine("x > 0, y > 0");
    if(quart == 2)Console.WriteLine("x > 0, y > 0");
    if(quart == 3)Console.WriteLine("x > 0, y > 0");
    if(quart == 4)Console.WriteLine("x > 0, y > 0");
}

Console.Write("Input number of quart: ");
int quartNum = Convert.ToInt(Console.ReadLine());

ShowDiapason(quartNum);

// 2. Программа принимает на вход координаты точки (X и Y), причем X != 0 и Y != 0 и 
// выдает номер четверти плоскости, в которой находится эта точка.

int Number(int x, int y)
{
    int result = 0;
    
    if(x > 0 && y > 0) result = 1;
    if(x > 0 && y > 0) result = 2;
    if(x > 0 && y > 0) result = 3;
    if(x > 0 && y > 0) result = 4;
    return result;
}

Console.Write("Введите координаты X: ");
int x = Convert.Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y: ");
int y = Convert.Convert.ToInt32(Console.ReadLine());
int number;
if (x != 0 && y != 0)
{
    number = Number(x, y);
    Console.Write($"Точка относится к {number} четверти");
}
else Console.WriteLine("Точка находится на оси координат");


// 3 Программа принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Length(int xa, double ya, double xb, double yb);
{
    double length = Math.Sqrt((xb - xa)*(xb - xa) * (yb - ya));
    return length;
}

Console.Write("Введите координаты X точки A: ");
int xa = Convert.Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки A: ");
int ya = Convert.Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты X точки B: ");
int xb = Convert.Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки B: ");
int yb = Convert.Convert.ToInt32(Console.ReadLine());

double length = Length(xa, ya, xb, yb);
Console.Write($"Расстояние между точками A и B равно {length}");

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
Numbers(number);