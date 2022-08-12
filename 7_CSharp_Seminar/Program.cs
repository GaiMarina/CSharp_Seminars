
//1. Задать двумерный массив размером m×n, заполненный случайными целыми числами. 

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) //Запятая показывает количество
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    
    return newArray;
}

 //Вывод на экран

 void Show2dArray(int[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++) //Длина по умолчанию с 0.
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
 }

 //=======================================
/*
 // 2. Задать двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
 // Вывести полученный массив на экран. 

int[,] ChangeArrayAsFormula(int rows, int columns) //Запятая показывает количество
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;
        }
    }
    
    return newArray;
}

Console.Write("Input the quantity of rows ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] ArrayCreated = ChangeArrayAsFormula(r, col);

Show2dArray(ArrayCreated);
*/
//========================================
/*
 // Задать двумерный массив. Найти элементы, у которых оба индекса чётные, 
 // и замените эти элементы на их квадраты. 

int[,] ChangeEvenIndices(int[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i+=2) 
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j] * array [i,j];
        }
    }
    return array;
 }

Console.Write("Input the quantity of rows ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(r, col, min, max);
Show2dArray(newArray);
Console.WriteLine();
int[,] ArrayCreated = ChangeEvenIndices(newArray);
Show2dArray(ArrayCreated);
*/
//=========================================

//Задать двумерный массив. 
//Найти сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 

int SumForMainDiagonal(int[,] array)
 {  
    int sum = 0;

    for(int i = 0; i < array.GetLength(0); i++) //Длина по умолчанию с 0.
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            if(i == j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
 }

 int SumForMainDiagonal2(int[,] array)
 {  
    int sum = 0;

    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++) //Длина по умолчанию с 0.
    {   
        sum += array[i,i];
    }

    return sum;
 }

Console.Write("Input the number of rows ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of columns ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(r, col, min, max);
Show2dArray(newArray);
Console.WriteLine();

int FinalSum = SumForMainDiagonal(newArray);
Console.WriteLine(FinalSum);
