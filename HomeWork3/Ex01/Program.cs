// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Унифицировал алгоритм, программа покажет является ли полиндромом число с любым 
// количеством цифр
Console.WriteLine("Write a number");
int digit = Convert.ToInt32(Console.ReadLine());
int ReverseNumb(int x)
{
    int a = 0;
    while (x > 0)
    {
        a = a*10 + x % 10;
        x = x/10;
    }
    return a;
}
int temp = ReverseNumb(digit);
// Console.WriteLine(temp);
if (temp == digit)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");
