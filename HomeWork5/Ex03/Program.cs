// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[] GetRandomArray(int length, int minValue, int maxValue)
{

    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(minValue, maxValue + 1);
    }

    return array;
}

int DiffBetweenMaxAndMinNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0 )
        {
            sum += array[i];
        }
    }
    return sum;
}

int lengthOfArray = ReadNumber("Enter the length of array");
int minValue = ReadNumber("Enter the minimum number in the array");
int maxValue = ReadNumber("Enter the maximal number in the array");
int[] array = GetRandomArray(lengthOfArray, minValue, maxValue);