// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumOfElemetsWithOddIndex(int[] array)
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

Console.WriteLine($"[{string.Join(' ', array)}]");
Console.WriteLine($"Sum of elemets with odd index {SumOfElemetsWithOddIndex(array)}");