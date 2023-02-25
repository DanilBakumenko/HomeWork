// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[] FillArrayRandom(int length, int minValue, int maxValue)
{
    int [] array = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        array[i] = Random.Shared.Next(minValue, maxValue + 1);
    }

    return array;
}

int length = ReadNumber("Enter the length of your array");
int minValue = ReadNumber("Enter the minimum number in the array");
int maxValue = ReadNumber("Enter the maximal number in the array");

int[] array = FillArrayRandom(length, minValue, maxValue);

var str = string.Join(" ", array);
Console.WriteLine(str);