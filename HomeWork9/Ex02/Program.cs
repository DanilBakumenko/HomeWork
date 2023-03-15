// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int GetSumForMToN(int M, int N)
{
    int sum = N;
    if( N > M )
    {
        sum += GetSumForMToN(M, N - 1);
    }
    return sum;
}
int M = ReadNumber("Enter M");
int N = ReadNumber("Enter N");
int sum = GetSumForMToN(M,N);
Console.WriteLine($"Sum = {sum}");
