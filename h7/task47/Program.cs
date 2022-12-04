double number = new Random().NextDouble();

 Console.WriteLine(Math.Round(number, 2));

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] table = new double[m, n];

void FillAndPrint(double[,] t)
 {
    for(int rows=0; rows<table.GetLength(0); rows++)
    {
        for (int colomns=0; colomns<table.GetLength(1); colomns++)
        {
            t[rows, colomns] = Math.Round((new Random().NextDouble()), 2);
            Console.Write($" {t[rows, colomns]}");
        }
    Console.WriteLine(" "); 
    }
 }

 FillAndPrint(table);