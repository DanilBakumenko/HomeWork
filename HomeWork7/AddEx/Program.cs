// Вывести первые N строк треугольника Паскаля
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void PrintPaskalTriangel(int rows)
{
    int[,] matrix = new int[rows, rows];

    matrix[0, 0] = 1;
    matrix[1, 0] = 1;
    matrix[1, 1] = 1;

    for (int i = 2; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (j == 0) { matrix[i, j] = matrix[i - 1, j]; }
            else { matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j]; }
        }
    }

    for (int i = 0; i < rows; i++)
    {
        int count =0;
        for (int j = 0; j < rows; j++)
        {
            if (matrix[i, j] > 9)
            {
                int temp = matrix[i, j];
                while (temp > 9)
                {
                    count++;
                    temp = temp / 10;
                }
            }

        }
        for (int j = 0; j < rows * 4 - i - count/2; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < rows; j++)
        {
            if (matrix[i, j] > 0)
            {
                Console.Write($"{matrix[i, j]} ");
                if (matrix[i, j] > 9)
                {
                    int temp = matrix[i, j];
                    while (temp > 9)
                    {
                        count++;
                        temp = temp / 10;
                    }
                }
            }
        }
        Console.WriteLine();
    }
}
// Без массива пирамида получается менее красивая, и может показать только 9 строк.
void PrintPaskalTriangelWithOutMatrix(int rows)
{
    int a = 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows - i / 2; j++)
        {
            Console.Write(" ");
        }
        Console.Write(a);
        if (a == 1)
        {
            a = 11;
        }
        else a *= 11;
        Console.WriteLine();
    }
}

int N = ReadNumber("Enter number of rows");
PrintPaskalTriangel(N);
