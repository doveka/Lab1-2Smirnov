Console.Write("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c: ");
double c = Convert.ToDouble(Console.ReadLine());

double medianA = 0.5 * Math.Sqrt(Math.Sqrt(Math.Pow(2 * b, 2) + Math.Pow(2 * c, 2) - Math.Pow(a, 2)));
double medianB = 0.5 * Math.Sqrt(Math.Sqrt(Math.Pow(2 * b, 2) + Math.Pow(2 * c, 2) - Math.Pow(a, 2)));
double medianC = 0.5 * Math.Sqrt(Math.Sqrt(Math.Pow(2 * b, 2) + Math.Pow(2 * c, 2) - Math.Pow(a, 2)));

Console.WriteLine("Медиана к стороне a: " + medianA);
Console.WriteLine("Медиана к стороне b: " + medianB);
Console.WriteLine("Медиана к стороне c: " + medianC);