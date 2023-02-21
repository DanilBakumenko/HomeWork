//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. (номер цифры считается от левого края)
Console.WriteLine("Write a number");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99)
{
        while (n > 1000)
        {
            n = n / 10;
        }
        Console.WriteLine($"Third number {n % 10}");
}
else Console.WriteLine("No third number");