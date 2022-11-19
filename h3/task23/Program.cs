Console.Write("Input number - ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count != number)
{
    count++;
    Console.WriteLine(count * count * count);
}