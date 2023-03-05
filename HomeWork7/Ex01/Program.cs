// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] GetRandomDoubleMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{

    double[,] matrix = new double[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextDouble()*rightBorder + leftBorder;
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{string.Format("{0:F2}", matrix[i,j])} ");
        }
        Console.WriteLine();
    }
}
int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
double[,] myMatrix = GetRandomDoubleMatrix(m, n);
PrintMatrix(myMatrix);