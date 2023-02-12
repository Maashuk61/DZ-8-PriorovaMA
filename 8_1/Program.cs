// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


void SortToLower(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int max = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = max;
                }
            }
        }
    }
}

const int rows = 3;
const int columns = 4;                      
const int leftRange = 0;
const int rightRange = 10;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);
SortToLower(array);
Console.WriteLine();
PrintMatrix(array);