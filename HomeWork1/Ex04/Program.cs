Console.WriteLine("Write a number n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("All numbers in range 1 to n:");
for (int i = 2; i < (n+1); i = i + 2)
{
    Console.Write($"{i} ");
}