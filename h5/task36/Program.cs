int[] FillArray(int size)
{
    int[] ar = new int[size];
    for (int i=0; i<size; i++)
    {
        ar[i] = new Random().Next(0, 10);
    }
    return ar;
}

int SumOdd(int[] coll, int size)
{
    int count = 0;
    for(int i=0; i<size; i++)
    {
        if (i % 2 != 0)
        {
            count = count + coll[i];
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] collection = FillArray(size);
Console.WriteLine("[" + string.Join(", ", collection) + "]");

Console.WriteLine($"Сумма нечетных чисел = {SumOdd(collection, size)}");