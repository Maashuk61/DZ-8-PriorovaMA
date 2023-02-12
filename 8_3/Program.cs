// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)   
{
    int[,] matr = new int[rows, columns];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)         
{
    for (int i = 0; i < matr.GetLength(0); i++)        
    {
        for (int j = 0; j < matr.GetLength(1); j++)   
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void RowMinElement(int[,] matr)
{
    int tempMin = 0;                                    
    int minSumRow = 0;                                  
    int sumRow = 0;                                     
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        tempMin=tempMin+matr[0, i];                     
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) sumRow += matr[i, j];    
        
        if (sumRow < tempMin)                                 
        {
            tempMin = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

const int rows = 3;
const int columns = 5;                     
const int leftRange = 0;
const int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);
Console.WriteLine();
RowMinElement(array);