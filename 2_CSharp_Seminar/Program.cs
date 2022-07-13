/*
// 1. Программа выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindBiggerDigit(int num) // Основная задача метода - рассмотреть случайное число.
                             // Программа берет int num и выводит int FindBiggerDigit.
{
    int ed = num % 10;   // Это две цифры, которые надо будет сравнить.
    int dec = num / 10;
    

    if(ed > dec) return ed;
    else return dec; 
}
*/
/*
// 1.1 Сокращаем количество return-ов в методе, кот.находит большую цифру в 2-хзначном числе.

int FindBiggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int max;

    if(ed > dec) max = ed;
    else max = dec; 

    return max;
}

int number = new Random().Next(10,100);
int digit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}"); 
// Тип форматирования. Console.WriteLine("Bigger digit of " + number + " is " + digit)
// В фигурных скобках - переменные.
*/
/*
// 1.2 Какие варианты метода с т.з того, что он возвращает (Void)

int FindBiggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int max;

    if(ed > dec) max = ed;
    else max = dec; 

    return max;
}

void FindBiggerDigitVoid(int num)

{
    int ed = num % 10;
    int dec = num / 10;
    int max;

    if(ed > dec) max = ed;
    else max = dec; 

    Console.WriteLine(max); // результат выводится сразу на консоль.
}

int number = new Random().Next(10,100);
int digit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}"); 

FindBiggerDigitVoid(38);
*/

// Вариант, когда результатом программы является да или нет.
// 2.0 Программа принимает 2 числа и  выводит является ли 2-е число кратным 1-му.
// to be multiple of a number.
/*
bool IsMultipleOf(int n1, int n2)
{
    if(n1 % n2 == 0) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool MultipleOf = IsMultipleOf(num1, num2);

Console.WriteLine(MultipleOf);
*/
/*
// Выводит случайное трехзначное число и удаляет вторую цифру этого числа. 

int RemoveTheSecondDigit(int num)
{
    int num1 = num / 100;
    int num2 = num % 10;
    int final = num1*10+num2;

    return final;
}

int number = new Random().Next(100,1000);
int result = RemoveTheSecondDigit(number);
Console.WriteLine($"Random number is {number}, the result is {result}");
*/
/*
// Принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.

bool IsMultipleOf(int num1)
{
    if(num1 % 7 == 0 && num1 % 23 == 0) return true;
    else return false;
}

Console.Write("Input an integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultipleOf(num1);

Console.WriteLine(result);
*/
/*
// Принимает 2 числа и определяет является ли одно число квадратом другого.

bool IsSquareOf(int n1, int n2)

{
    if(n1 == n2 * n2 || n2 == n1 * n1) return true;
    else return false;
}

Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquareOf(num1, num2);
Console.WriteLine(result);
*/