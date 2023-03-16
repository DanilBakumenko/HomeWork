// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Ackermann(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return Ackermann(M-1,1);
    }
    else
    {
        return Ackermann(M-1, Ackermann(M,N-1));
    }
}
int M = ReadNumber("Enter M");
int N = ReadNumber("Enter N");
int result = Ackermann(M,N);
Console.WriteLine($"{result}");
