// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void PrintNumberForNTo1(int N)
{
    if (N > 0)
    {
        Console.Write($"{N} ");
        PrintNumberForNTo1(N - 1);
    }
}
int N = ReadNumber("Enter N");
PrintNumberForNTo1(N);