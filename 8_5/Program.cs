//  Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




int temp = 1;
int i = 0;
int j = 0;


void FillArray(int[,] matr)
{
    while (temp <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}




void WriteArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] / 10 <= 0)
                Console.Write($" {matr[i, j]} ");

            else Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int n=4;
int[,] array = new int[n, n];
FillArray(array);
WriteArray(array);
