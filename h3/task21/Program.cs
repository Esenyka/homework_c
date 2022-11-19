Console.WriteLine("Input A(x)");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input A(y)");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input A(z)");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B(x)");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B(y)");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B(z)");
double z2 = Convert.ToInt32(Console.ReadLine());

double x = x1 - x2;
double y = y1 - y2;
double z = z1 - z2;

double answer = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

Console.WriteLine(Math.Round(answer, 2));