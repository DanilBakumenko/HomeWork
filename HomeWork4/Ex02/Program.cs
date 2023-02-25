// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = int.Parse(Console.ReadLine());
    return value;
}
int SummAllDigit (int digit)
{
    int result = 0;
    while (digit > 0)
    {
        result += digit%10; 
        digit = digit / 10;
    } 
    return result;
}
int n = ReadNumber("Enter a number");
int answer = SummAllDigit(n);
Console.WriteLine(answer);
