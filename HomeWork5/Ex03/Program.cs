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
    int max = 0;
    int min = 2147483647;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i]< min)
        {
            min = array[i];
        }
    }
    return (max - min);
}

int lengthOfArray = ReadNumber("Enter the length of array");
int minValue = ReadNumber("Enter the minimum number in the array");
int maxValue = ReadNumber("Enter the maximal number in the array");
int[] array = GetRandomArray(lengthOfArray, minValue, maxValue);
Console.WriteLine($"[{string.Join(' ', array)}]");

Console.WriteLine($"Difference between maximum and minimum number in the array {DiffBetweenMaxAndMinNumber(array)}");