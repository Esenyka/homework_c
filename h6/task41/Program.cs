// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 
// 0, 7, 8, -2, -2 -> 2
// 
// 1, -7, 567, 89, 223-> 3

int Pos(int[] a)
{
    int count = 0;
    for (int i=0; i<a.Length; i++)
    {
        if (a[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

for (int i=0; i<size; i++)
{
    Console.Write($"Введите {i+1}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"{Pos(array)} число(ла, ел) больше 0");