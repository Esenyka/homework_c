Console.Write("Введите длину массива - ");
int len = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[len];
int count = 0;

while (count != len)
{
    int number = new Random().Next(1, 100);
    arr[count] = number;
    count++;
}
Console.Write("[" + string.Join(", ", arr) + "]");