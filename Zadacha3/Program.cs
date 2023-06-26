// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int [,] matrixOne = new int [2,2];
int [,] matrixTwo = new int [2,2];
int [,] GetMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,5);
        }
    }return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int [,] matrixTree = new int [2,2];

int [,] MultiplicMassiv (int[,] array)
{
   int length = 2;
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        for (int k = 0; k < length; k++)
        {
            matrixTree[i, j] = matrixTree[i, j] + (matrixOne[i, k] * matrixTwo[k, j]);
        }
    }

}
return array;
}


GetMatrix(matrixOne);
GetMatrix(matrixTwo);
MultiplicMassiv(matrixTree);
Console.WriteLine("Матрица А :");
PrintMatrix(matrixOne);
Console.WriteLine();
Console.WriteLine("Матрица В :");
PrintMatrix(matrixTwo);
Console.WriteLine();
Console.WriteLine("Матрица A * B : ");
PrintMatrix(matrixTree);
Console.WriteLine();