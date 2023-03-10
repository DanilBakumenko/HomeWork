int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
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

int[,] SpiralFilling(int row, int columns)
{
    int[,] matrix = new int[row, columns];
    int quantity = row * columns + 1;
    int i = 0;
    int j = 0;
    for (int k = 1; k < quantity; k++)
    {
        matrix[i, j] = k;
        if (j < columns - 1 && matrix[i, j + 1] == 0 )
        {
            if (i != 0)
            {
                if (matrix[i - 1, j] != 0)
                {
                    j++;
                }
                else if (matrix[i-1, j] == 0)
                {
                    i += -1;
                }
            }
            else if (i == 0) { j++; }
        }
        else if (i < row - 1 && matrix[i + 1, j] == 0)
        {
            i++;
        }
        else if (j > 0 && matrix[i,j-1] == 0 )
        {
            j += -1;
        }
        else if ( matrix[i-1, j] == 0)
        {
            i+= -1;
        }
    }
    return matrix;
}

int m = ReadNumber("Enter the number of row");
int n = ReadNumber("Enter the number of colum");
int[,] myMatrix = SpiralFilling(m, n);
PrintMatrix(myMatrix);