// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Write a number");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
{
    Console.WriteLine("Today is a day off");
}
else if (n > 0 && n < 6)
{
    Console.WriteLine("Go to work!");
}
else Console.WriteLine("Day does not exist");