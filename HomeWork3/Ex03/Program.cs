// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int N = ReadNumber("Enter the digit");
for (int i = 1; i < N+1; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
