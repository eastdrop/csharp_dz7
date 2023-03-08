/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

1, 7->такого числа в массиве нет*/

int[] InputArr(string text)
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
}

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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ReturnInt(int[,] matr, int[] strCol)
{
    if (strCol[0] >= matr.GetLength(0) || strCol[1] >= matr.GetLength(1))
    Console.WriteLine("Такого элемента не существует");
    else
    Console.WriteLine(matr[strCol[0], strCol[1]]);

}
int[] strCol = InputArr("Input string and column");
var myMatrix = GenerateMatrix(5, 5);
PrintMatrix(myMatrix);
Console.WriteLine();
ReturnInt(myMatrix, strCol);


