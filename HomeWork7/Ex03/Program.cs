// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintAverageOfColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average += matrix[j, i];
        }
        Console.Write($"{string.Format("{0:F2}", average / matrix.GetLength(0))} ");
    }
}

int m = ReadNumber("Enter number of rows");
int n = ReadNumber("Enter number of colums");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
PrintAverageOfColumns(myMatrix);
