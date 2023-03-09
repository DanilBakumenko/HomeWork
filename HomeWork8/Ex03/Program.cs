// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] firstMatrix =
{
    {1,4,7,2},

    {5,9,2,3},

    {8,4,2,4},

    {5,2,6,7}
};

int[,] secondMatrix =
{
    {1,5,8,5},

    {4,9,4,2},

    {7,2,2,6},

    {2,3,4,7}
};

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] ProuctOfTwoMatrices (int [,] matrix1, int[,] matirx2)
{
    int[,] product = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            product[i,j]= matrix1[i,j]*matirx2[i,j];
        }
    }
    return product;
}
int[,] product = ProuctOfTwoMatrices(firstMatrix,secondMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
PrintMatrix(product);
