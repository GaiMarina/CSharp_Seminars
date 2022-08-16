
/*
// 1. Задать двумерный массив. Написать программу, которая поменяет местами первую и 
//    последнюю строку массива. 

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
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

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SwapLines(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {   
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }

    return array;
}

Console.Write("Input the number of rows ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of columns ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
Console.WriteLine();
Show2dArray(SwapLines(array));
*/
//====================================

// 2. Задать двумерный массив. Написать программу, которая заменяет строки на столбцы. 
//    В случае, если это невозможно, программа должна вывести сообщение для пользователя. 
//    (Cередина 2d массива - относительно гл.диагонали)

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
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

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] ReplaceRowsColumns(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i,j] = array[j,i];
        }
    }

    return newArray;
}

Console.Write("Input the number of rows ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of columns ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

Console.WriteLine();

if(array.GetLength(0) != array.GetLength(1))
    Console.WriteLine("The array is not square.");
else
    Show2dArray(ReplaceRowsColumns(array));



//==========================
/*
// 3. Из двумерного массива целых чисел удалить строку и столбец, 
//    на пересечении которых расположен наименьший элемент. 

int[,] CutArray(int[,] array)
{
    int iMin = 0, jMin = 0;
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

            if(array[i,j] < array[iMin,jMin])
            {
                iMin = i; 
                jMin = j;
            }
                
        }
    }

    for(int i = 0, m = 0; i < array.GetLength(0); i++, m++)
    {
        if(i == iMin && i != array.GetLength(0) - 1) i++;
        {
            i--;
            continue;
        }

        for(int j = 0, n = 0; j < newArray.GetLength(1); j++, n++)
        {
            if(j ==jMin) j++;
            newArray[m,n] = array[i,j];
        }
    }
    return newArray;
}

Console.Write("Input the number of rows ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of columns ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
Show2dArray(CutArray(array));


//if(array[i,j == 5]) continue; //завершает повторение, переходит сразу в j++
//array[i,j] = 0;
*/