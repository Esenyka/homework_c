// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

int NumberOfDight(int n, int i)
{
    if (n <= 0)
    {
        return i;
    }
    else 
    {
        return NumberOfDight(n / 10, i + 1);
    }
}


Console.WriteLine("Введите цифры: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberOfDight(num, 0));
