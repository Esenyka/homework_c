// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] firstMatrix = new int[2, 2];
FillArray(firstMatrix);
Console.WriteLine(" ");

int[,] secondMatrix = new int[2, 2];
FillArray(secondMatrix);
Console.WriteLine(" ");

int[,] newMatrix = new int[2, 2];

newMatrix[0, 0] = (firstMatrix[0, 0] * secondMatrix[0, 0]) + (firstMatrix[0, 1] * secondMatrix[1, 0]);
newMatrix[0, 1] = (firstMatrix[0, 0] * secondMatrix[0, 1]) + (firstMatrix[0, 1] * secondMatrix[1, 1]);
newMatrix[1, 0] = (firstMatrix[1, 0] * secondMatrix[0, 0]) + (firstMatrix[1, 1] * secondMatrix[1, 0]);
newMatrix[1, 1] = (firstMatrix[1, 0] * secondMatrix[0, 0]) + (firstMatrix[1, 1] * secondMatrix[1, 1]);


Print(newMatrix);


void Print(int[,] m)
{
    for(int row=0; row<m.GetLength(0); row++)
    {
        for(int colomn=0; colomn<m.GetLength(1); colomn++)
        {
            Console.Write($" {newMatrix[row, colomn]}");
        }
        Console.WriteLine(" ");
    }
}

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