Console.WriteLine("Write number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write number b");
int b = Convert.ToInt32(Console.ReadLine());
if (b < a)
{
    Console.WriteLine($"Min = {b}, Max = {a}");
}
else
{
    Console.WriteLine($"Min = {a}, Max = {b}");
}