// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
Console.WriteLine("Write the coordinates of two points in spase");
double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double xa = ReadNumber("Write the coordinate X for point A");
double ya = ReadNumber("Write the coordinate Y for point A");
double za = ReadNumber("Write the coordinate Z for point A");
double xb = ReadNumber("Write the coordinate X for point B");
double yb = ReadNumber("Write the coordinate Y for point B");
double zb = ReadNumber("Write the coordinate Z for point B");

double result = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine($"{result:f2}");