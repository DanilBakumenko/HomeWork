// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int QuantityOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
int lengthOfArray = ReadNumber("Enter the length of array");
int minValue = 100;
int maxValue = 999;

int[] array = GetRandomArray(lengthOfArray, minValue, maxValue);

int quantity = QuantityOfEvenNumbers(array);

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"We found {quantity} even numbers"); 