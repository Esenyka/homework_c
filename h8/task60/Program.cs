//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
//будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array)
{
    for(int row=0; row<array.GetLength(0); row++)
    {
        for(int colomn=0; colomn<array.GetLength(1); colomn++)
        {
            for(int i=0; i<array.GetLength(2); i++)
            {
                array[row, colomn, i] = new Random().Next(9, 99);
                Console.Write($" {array[row, colomn, i]}({row};{colomn};{i})");
            }
            Console.WriteLine(" ");
       }       
    }
}


int[,,] matrix = new int[2, 2, 2];

FillArray(matrix);
