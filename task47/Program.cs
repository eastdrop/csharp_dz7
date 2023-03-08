/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами*/

double[,] GenerateMatrix(int str, int column)
{
    double[,] matrix = new double[str, column];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble(), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

var newMatrix = GenerateMatrix(5, 5);
PrintMatrix(newMatrix);