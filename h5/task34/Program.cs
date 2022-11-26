int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int evenNum(int[] coll, int size)
{
    int count = 0;
    for(int i=0; i<size; i++)
    {
        if (coll[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите длину массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] numbers = FillArray(userSize);
Console.WriteLine("[" + string.Join( ", ", numbers) + "]");

Console.WriteLine($"Колличество четных чисел = {evenNum(numbers, userSize)}");