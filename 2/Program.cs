int x1 = number("x","A");
int y1 = number("y","A");
int z1 = number("z","A");
int x2 = number("x","A");
int y2 = number("y","A");
int z2 = number("z","A");

int number (string point1, string point2)
{
    Console.Write($"Введите координату {point1} точки  {point2} ");
    return Convert.ToInt16(Console.ReadLine());
}
double equation (double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1), 2));
}
double lengt = Math.Round(equation(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длинна {lengt}");


