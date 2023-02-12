// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Get3DMatrix(int rows, int columns, int layers, int leftRange, int rightRange)
{
    int[,,] matr = new int[rows, columns, layers];
    int uniqNumber = 10;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = matr[i, j, k] + uniqNumber;
                uniqNumber++;
            }
        }

    }
    return matr;
}

void Print3DMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($" {matr[i, j, k]}  [{i},{j},{k}] ");
            }
            Console.WriteLine();
        }

    }
}


const int rows = 2;
const int columns = 2;
const int layers = 2;
const int leftRange = 10;
const int rightRange = 99;

int[,,] array = Get3DMatrix(rows, columns, layers, leftRange, rightRange);
Print3DMatrix(array);
Console.WriteLine();