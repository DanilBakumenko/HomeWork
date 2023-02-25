// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = int.Parse(Console.ReadLine());
    return value;
}
int Exponential(int basedDigit, int degree)
{
    int res = basedDigit;
    for (int i = 1; i < degree; i++)
    {
        res = res * basedDigit;
    }
    return res;
}
int a = ReadNumber("Write A");
int b = ReadNumber("Write B");
int answer = Exponential(a,b);
Console.WriteLine(answer);