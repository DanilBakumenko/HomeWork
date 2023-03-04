double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}
double b1 = ReadNumber("Enter the b1");
double k1 = ReadNumber("Enter the k1");
double b2 = ReadNumber("Enter the b2");
double k2 = ReadNumber("Enter the k2");
double x = (b1 - b2)/(k2 - k1);
double y= k1 * x + b1;

Console.WriteLine($"{x} {y}");