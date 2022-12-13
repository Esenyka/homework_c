//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int FuncAccermana(int m, int n)
{
    if(m==0) return n + 1;
    if(n==0) return FuncAccermana(m-1, 1);
    if(m>0 && n>0) return FuncAccermana(m-1, FuncAccermana(m, n-1));
    else return 0;
}

Console.Write("Введите число m ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FuncAccermana(M, N));