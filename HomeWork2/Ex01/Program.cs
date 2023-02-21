// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Write a number");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
    n = n / 10;
    n = n % 10;
    Console.WriteLine(n);
}
else Console.WriteLine("Eror");