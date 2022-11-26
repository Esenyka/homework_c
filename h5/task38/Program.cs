double[] FillArray()
{
    double[] ar = new double[10];
    for (int i=0; i<10; i++)
    {
        ar[i] = new Random().Next(2, 100);
    }
    return ar;
}

double MaxMin(double[] coll)
{
    double max = coll[0];
    double min = coll[0];
    int l = coll.Length;
    int count = 0;
    double result = 0;
    while(count != l)
    {
        if (coll[count] > max)
        {
            max = coll[count];
        }
        if (coll[count] < min)
        {
            min = coll[count];
        }
        count ++;
    }
    result = max - min;
    return result;
}

double[] numbers = FillArray();
Console.WriteLine("[" + string.Join(", ", numbers) + "]");

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {MaxMin(numbers)}");