// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,,] Get3DArray (int x,int y, int z)
{
    int temp = 10;
    int[,,] array3D = new int[z,y,x];
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < x; k++)
            {
                array3D[i,j,k] = temp;
                temp++;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
int x = ReadNumber("Enter length of array");
int y = ReadNumber("Enter width of array");
int z = ReadNumber("Enter depth of array ");
int[,,] myArray = Get3DArray(x,y,z);
Print3DArray(myArray);
