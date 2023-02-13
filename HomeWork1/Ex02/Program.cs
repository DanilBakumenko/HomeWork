int i = 0;
int max = 0;
while (i < 3)
{
    Console.WriteLine("Write a number ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (max < a) 
    {
        max = a;
    }
    i++;
}
Console.WriteLine($"Max number = {max}");

