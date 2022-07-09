/*
// 1. Программа на вход принимает два числа и проверяет, является ли первое число квадратом второго.

int num1, num2; //quad убрали

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());  //переводим число из "23" в 23
Console.Write("Input second integer number: "); 
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)   //скобки убрали, т.к. одно действие
    Console.WriteLine("Yes");  // отступы нужны. Строчка - в подчинении.
else 
    Console.WriteLine("No");
*/

/*
// 1. Задача через переменную string result. Верхний вариант более оптимизирован/быстрый.
 int num1, num2; 
string result;
Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());  //переводим число из "23" в 23
Console.Write("Input second integer number: "); 
num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2 * num2)   //скобки убрали, т.к. одно действие
    result = "Yes";  // отступы нужны: трочка - в подчинении.
else 
    result = "No";
    Console.WriteLine(result);*/
