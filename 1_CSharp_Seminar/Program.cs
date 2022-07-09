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
    Console.WriteLine(result);
    */
/*
// Задача 2. Программа на вход принимает одно число (N), а на выходе показывает все целые числа в 
// промежутке от -N до N.

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++; //  то же самое, что и current + 1
}
// Сделать проверку на ерунду.

*/
/*
// Задача 3: Получить из длинного числа трехзначное.

int a = 1325241325;

while(a > 999)
{
    a /= 10; // то же самое, что и а = а / 10
}

Console.WriteLine(a + " ");
*/
/*
//Задача 4: Программа выдает название дня недели по заданному номеру.

Console.Write("Input positive integer number from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 1)
    Console.WriteLine("Monday" + " ");
if(num == 2)
    Console.WriteLine("Tuesday" + " ");
if(num == 3)
    Console.WriteLine("Wednesday" + " ");
if(num == 4)
    Console.WriteLine("Friday" + " ");
if(num == 5)
    Console.WriteLine("Friday" + " ");
if(num == 6)
    Console.WriteLine("Saturday" + " ");
if(num == 7)
    Console.WriteLine("Sunday" + " ");
*/
/*
// Задача 5: Программа на вход принимает число и выдает его квадрат

int num1, quad;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());  

quad = num1 * num1;

Console.WriteLine(quad);
*/