// 1. Задать массив из 12 элементов, заполнить случайными числами из промежутка [-9,9].

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; //задали место для массива
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
        
    return newArray; 
}   

// Метод, который осуществляет ввод каждой цифры массива от пользователя.
int[] CreateArray(int size)
{
    int[] newArray = new int[size]; // создали массив, выделили под него память

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
/*
int[] Array = CreateArray(5); //Ввели вручную массив и распечатали.
ShowArray(Array);
*/
// 2. Метод ищет сумму положительных элементов массива.
int SumOfPositive(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) 
            sum += array[i];
    
    return sum;
}

/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] Array = CreateRandomArray(size, min, max); 
ShowArray(Array);

Console.WriteLine("The sum of positive elements is " + SumOfPositive(Array));
*/
//===================================
/*
// 3.  Написать программу: замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] ChangeSign(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
        Array[i] *= -1;
    return Array;
}

Console.Write("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of an element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of an element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] NewArray = CreateRandomArray(size, min, max);
ShowArray(NewArray);
ChangeSign(NewArray);
ShowArray(NewArray);

*///=======================================
/*
// 4. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 

bool FindNumber(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == num) return true;
    return false;
}

Console.Write("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of an element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of an element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an integer number to find ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NewArray = CreateRandomArray(size, min, max);
ShowArray(NewArray);
Console.WriteLine(FindNumber(NewArray, number));
*/
//=====================

// 5. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] CreateArrayOfSize(int size)
{
    int[] NewArray = new int[size];

    for(int i = 0; i < size; i++)
    NewArray[i] = new Random().Next();
    return NewArray;
}

int CountTheQuantity(int[] array)
{   
    int count = 0;
    
    for(int i = 0; i < array.Length; i++) 

    if(array[i] >= 10 & array[i] <= 99)
    count++;

    return count;
}

int[] NewArray = CreateRandomArray(12,-55, 10);

//int[] NewArray = CreateArrayOfSize(12);

ShowArray(NewArray);

Console.WriteLine($"The number of array elements from the segment [10,99] is {CountTheQuantity(NewArray)}");

// 6. Найти произведение пар чисел в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследний и т.д. Результат записать в новом массиве.

