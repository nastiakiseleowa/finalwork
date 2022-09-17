Console.Write("Введите a ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c ");
double c = Convert.ToDouble(Console.ReadLine());
double x1 = 0;
double x2 = 0;
double D = 0;

D = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"D = {D}");
if (D > 0 )
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"x1 = {x1} x2 = {x2}");
}
else if (D == 0 )
{
    x1 = (-b  / (2 * a));
    Console.WriteLine($"x = {x1}");
}
else
{
    Console.WriteLine("Корней нет");
}