
// РЕКУРСИИ //
/*
// 1. Задать значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N. 

void ShowNums(int n)
{
    if(n != 1) ShowNums(n - 1); //нельзя тот же аргумент использовать(бесконечная рекурсия)

    Console.Write(n + " ");
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/
//===========================
/*
// 1.Задача в обратном порядке.
void ShowNums(int n)
{
    if(n >= 1) 
    {
        Console.Write(n + " ");
        ShowNums(n - 1);
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/
//========================
/*
// 1 задача 3 вариант. Обратный порядок.

void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n != 1) ShowNums(n - 1);
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/
//===========================
/*
// 2. Написать программу, которая будет принимать на вход число и возвращать сумму его цифр. 

int SumOfDigits(int n)
{
    if(n != 0) return n % 10 + SumOfDigits(n / 10);
    return 0;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"SumOfDigits in {num} is {SumOfDigits(num)}");
*/
//======================
/*
// 3.Задать значения M и N. Написать программу, которая выведет все натуральные числа 
//   в промежутке от M до N. 

void AllNaturals(int n, int m)
{
    if(m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }

    if(n != m)
        AllNaturals(m, n - 1);

    Console.Write(n + " ");       
}

Console.Write("Input the positive integer number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the positive integer number N: ");
int n = Convert.ToInt32(Console.ReadLine());

AllNaturals(m, n);
*/
//=======================

// 4. Напишите программу, которая на вход принимает два числа A и B, 
//    и возводит число А в целую степень B с помощью рекурсии. 

int Degree(int a, int b)
{
    if (b!=0) return a * Degree(a, b-1);
        return 1;
}

Console.Write("Input the positive integer number A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the positive integer number B: ");
int b = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"The number {a} to the power of {b} equals {Degree(a, b)}"); 