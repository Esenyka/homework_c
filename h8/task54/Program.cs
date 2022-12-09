//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.

void FillArray(int[,] array)
{
    for(int row=0; row<array.GetLength(0); row++)
    {
        for(int colomn=0; colomn<array.GetLength(1); colomn++)
        {
            array[row, colomn] = new Random().Next(0, 9);
            Console.Write($" {array[row, colomn]}");
        }
        Console.WriteLine(" ");
    }
}

void PrintArray(int[,] array)
{
    for(int row=0; row<array.GetLength(0); row++)
    {
        for(int colomn=0; colomn<array.GetLength(1); colomn++)
        {
            Console.Write($" {array[row, colomn]}");
        }
        Console.WriteLine(" ");
    }
}

void ChangeArray(int[,] m, int row)
{
    for (int i = 0; i < m.GetLength(1) - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < m.GetLength(1) ; j++)
        {
            if (m[row, j] > m[row, minPosition]) 
            {
                minPosition = j;
            }
}
        
        int temporrary = m[row, i];
        m[row, i] = m[row, minPosition];
        m[row, minPosition] = temporrary;
    }
}


int[,] matrix = new int[4, 4];
FillArray(matrix);
Console.WriteLine(" ");
for(int i=0; i<matrix.GetLength(1); i++)
{
    ChangeArray(matrix, i);
}
PrintArray(matrix);
