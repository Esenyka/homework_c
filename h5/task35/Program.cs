int[] FillArray(int size)
{
    int[] ar = new int[size];
    for (int i=0; i<size; i++)
    {
        ar[i] = new Random().Next(0, 500);
    }
    return ar;
}

void ElBetween(int[] arr, int mi, int ma)
{
   int count = 0;
   for(int i=0; i<arr.Length; i++)
   {
       if (arr[i] > mi && arr[i] < ma)
       {
           count++;
       }
   }
   Console.WriteLine($"{count} числел в промежутке с {mi} до {ma}");
}

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size);
Console.WriteLine("[" + string.Join(", ", array) + "]");
ElBetween(array, min, max);