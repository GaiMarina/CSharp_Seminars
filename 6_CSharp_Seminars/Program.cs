
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

//======================================

// 1. Программа, которая перевернет одномерный массив (последний элемент на первом месте, а первый на последнем).

int[] ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    
     return array;
}

//======================================

// Генерация дробных элементов. Случайных вещественных чисел.

double number = new Random().Next(1,10) + new Random().NExtDouble(); //Отдельно генерируем целую часть, отдельно дробную часть.

// Можем создать рандомовский объект

Random rand = new Random(); // Место под объект.

double number = rand.Next(1,10) + rand.NextDouble(); 
*/
//====================================
// 2. Программа, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины. 
/*
bool Triangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b)
        return true;
    return false;
}

//===================================
/*
// Програма, которая будет преобразовывать десятичное число в двоичное. 

 string Transformation(int number)
 { 
    string result = string.Empty;

    while(number > 0)
    {
        result = number % 2 + result; // конкатенация (склеиваем, дописывая слева направо)
        number /= 2;
    }

    return result;
    
 }

string res = Transformation(10);
Console.WriteLine(res);
*/
//===================================
/*
// Не используя рекурсию, ввести первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 

int[] Fibonacci(int N)
{
    int[] newFibonacci = new int[N];

    newFibonacci[0] = a;
    newFibonacci[1] = b;

    for(int i = 2; i < N; i++)
    {
        newFibonacci[i] = newFibonacci[i - 1] + newFibonacci[i - 2];
    }
    
    return newFibonacci;
}

Console.WriteLine("Input the quantity of numbers N ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NewFibonacci = Fibonacci(num);

ShowArray(NewFibonacci);
*/