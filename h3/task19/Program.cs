Console.Write("Input number - ");
string number = Console.ReadLine();
int numInt = Convert.ToInt32(number);

if (numInt  > 99999)
{
    Console.WriteLine("Length of number more than 5");
}
else if (numInt < 0)
{
    if (number[1] == number[5] && number[2] == number[4])
    {
        Console.WriteLine("Yes");
    }
    else Console.WriteLine("No");
}
else
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Yes");
    }
    else Console.WriteLine("No");
}

//... С любой длинной до 10 символов(еще не знаю как исправить, 
// но поняла что проблема в Int32, так как он может хранить значение до 2 147 483 647)

Console.Write("Input number - ");
string n = Console.ReadLine();
int nInt = Convert.ToInt32(n);
int l = n.Length;
int numOper = 0;
int count = 0;
int count1 = l - 1;


if (l % 2 == 0)
{
    numOper = l / 2;
}
else 
{
    numOper = (l - 1) / 2;
}

while (count != numOper)
{
    if (n[count] == n[count1])
    {
        count++;
        count1 = count1 - 1;
        if (count == numOper)
        {
            Console.WriteLine("Yes");
        }
    }
    else 
    {
        Console.WriteLine("No");
        break;
    }
}

