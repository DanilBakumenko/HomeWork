int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int M = ReadNumber("How mani numbers you enter");
int count = 0;
for (int i = 0; i < M; i++)
{
    int m = ReadNumber("Enter the number");
    if (m > 0) count++;
}
Console.WriteLine($"You enter {count} numbers > 0");