//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Num(int number)
{
    if(number != 0)
    {
        Console.Write($" {number}");
        Num(number - 1);
    }
}

Console.Write("Введите цифру ");
int  n = Convert.ToInt32(Console.ReadLine());

Num(n);