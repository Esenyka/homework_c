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



int[,] table = new int[4, 4];
Fill(table);

Console.Write("Введите желаемую строку: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемый солбец: ");
int colomn = Convert.ToInt32(Console.ReadLine());

if(row <= table.GetLength(0) & colomn <= table.GetLength(1))
{
    Console.WriteLine(table[row, colomn]);
}
else
{
    Console.Write($"Таблица не такая большая...");
}

