// dotnet new console
/*
// Task 1. Принимает на вход число и выдает количество цифр в числе.

int NumOfDigits(int num) // И там и там - int => сразу вводим переменную на выход.
{
    int count = 0;

    while(num != 0)
    {
        num /= 10;
        count++;
    }

    return count;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);

Console.WriteLine($"Number of digits of {number} is {result}");
*/
//================================
/*
// Task 2. Принимает на вход число (А) и выдает сумму чисел от 1 до А.

int SumOfNum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++) 
    {
        sum += i;
    }
    
    return sum;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfNum(number);

Console.WriteLine($"Sum of numbers from 1 to {number} is {result}");
*/
//===============================
/*
// Task 3. Принимает на вход число (N) и выдает произведение чисел от 1 до N, кратных 3-м.

long MultiplationOfNum(int num)
{
    long result = 1;
    
    for (int i = 3; i <= num; i += 3) 
    {
        result *= i;
    }
    
    return result;
}

Console.Write("Input positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 3) Console.WriteLine("The number is less than 3");
else
{
    long multiplationOfNum = MultiplationOfNum(number);

    Console.WriteLine($"The multiplation of numbers from 1 to {number} that is multiple of 3 is {multiplationOfNum}");
}
*/
//===========================
/*
// Task 4. Массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Генерация целочисленного массива заполняемого случайными элементами.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; //запомнить!

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
        
    return newArray; //возвращаем сам массив.
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] binaryArray = CreateRandomArray(8, 0, 1);

ShowArray(binaryArray);
*/