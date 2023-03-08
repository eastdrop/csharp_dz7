/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GenerateMatrix(int str, int column)
{
    int[,] matrix = new int[str, column];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void ColumnAverage(int[,] matrix)
{

    
    for (int j = 0;j < matrix.GetLength(0);j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0;i < matrix.GetLength(1);i++)
        {
            sum += matrix[i, j];
        }
        average = sum / matrix.GetLength(1);
        Math.Round(average);
        Console.Write(average + " ");
    }
    
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GenerateMatrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
ColumnAverage(matrix);