// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А - ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B - ");
int b = Convert.ToInt32(Console.ReadLine());

int count = 1;
int result = a;
while(count != b)
{
    result = result * a;
    count++;
}

Console.WriteLine(result);