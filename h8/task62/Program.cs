//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

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

int[,] matrix = new int[4, 4];

int count = 0;
int num = 1;
int r = 0;
int c = 0;


while(count != (matrix.GetLength(0) * matrix.GetLength(1)))
{
    count++;
    if(c < 3 && r == 0) 
    {
        matrix[r, c] = num; 
        c++;
        num++;
    }
    else if (c == 3 && r < 3)
    {
        matrix[r, c] = num;
        r++;
        num++;
    }
    else if(c > 0  && r == 3)
    {
        matrix[r, c] = num;
        num++;
        c--;
    }
    else if(c == 0 && r > 1)
    {
        matrix[r, c] = num;
        num++;
        r--;
    }
    else if (r == 1 && c < 2) 
    {
        matrix[r, c] = num;
        num++;
        c++;
    }
    else if (r == 1 && c == 2)
    {
        matrix[r, c] = 14; 
        r++; 
        num++;
    }
    else if (r == 2 && c == 2) 
    {
        matrix[r, c] = 15; 
        num++; 
        c--;
    }
    else if (r == 2 && c == 1) matrix[r, c] = 16;

}

PrintArray(matrix);
