// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

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

int Sum(int[,] array, int row)
{
    int sum = 0;
    for(int colomn=0; colomn<array.GetLength(1); colomn++)
    {
        sum = sum + array[row, colomn];
    }
    return sum;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);

int max = Sum(matrix, 0);
int result = 0;
for (int i=0; i<matrix.GetLength(0); i++)
{
    if (Sum(matrix, i) > max) 
    {   
        max = Sum(matrix, i); 
        result = i;
    }
}

Console.WriteLine($"Строчка с максимальной суммой элементов - {result+1}");

