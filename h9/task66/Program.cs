//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

int Sum(int m, int n)
{
    if(m == n) return m;
    else return n + Sum(m, n-1); 
}

Console.Write("Введите число m ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(first, second));

