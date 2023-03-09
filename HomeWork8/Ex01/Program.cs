// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }

    return matrix;
}

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

void SortNumbersInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int jTemp = matrix.GetLength(1) - 1;
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] > matrix[i, jTemp])
            {
                temp = matrix[i, jTemp];
                matrix[i, jTemp] = matrix[i, j];
                matrix[i, j] = temp;
            }
            else if (matrix[i, j] > matrix[i, j + 1])
            {
                jTemp = jTemp - 1;
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j+1];
                matrix[i, j+1] = temp;
            }
            if (matrix[i,j] < matrix[i,0])
            {
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,0];
                matrix[i,0] = temp;
            }
        }
    }
}

int m = ReadNumber("Enter the number of row");
int n = ReadNumber("Enter the number of colum");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);