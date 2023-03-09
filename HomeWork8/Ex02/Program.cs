// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

int FindTheRowWithTheSmallestSum(int[,] matrix)
{
    int iTemp = 0;
    int minSum = 2147483647; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumTemp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumTemp += matrix[i,j];
        }
        if (sumTemp < minSum)
        {
            minSum = sumTemp;
            iTemp = i;
        }
    }
    return iTemp;
}

int m = ReadNumber("Enter number of rows");
int n = ReadNumber("Enter number of colums");
int[,] myMatrix = GetRandomMatrix(m, n);
int rowIndex = FindTheRowWithTheSmallestSum(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine();
Console.WriteLine($"Index of the row with smallest sum is {rowIndex}");
