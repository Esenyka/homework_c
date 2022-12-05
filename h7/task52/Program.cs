void Fill(int[,] t)
{
   for(int rows=0; rows<t.GetLength(0); rows++)
   {
        for (int colomns=0; colomns<t.GetLength(1); colomns++)
        {
            t[rows, colomns] = new Random().Next(0, 9);
            Console.Write($" {t[rows, colomns]}");
        }
    Console.WriteLine(" "); 
    }
}

double Something(int[,] t, int colomn)
{
    double result = 0;
    for (int rows=0; rows<t.GetLength(0); rows++)
    {
        result = result + t[rows, colomn];    
    }
    return Math.Round(result/t.GetLength(0), 2);
}

int[,] table = new int[4, 4];
Fill(table);

for (int colomns=0; colomns<table.GetLength(1);colomns++)
{
    Console.Write($"{Something(table, colomns)}; ");
}
