Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int SequenceOfNumbers(int n, int m)
{
    if (n <= m) return n + SequenceOfNumbers(n + 1, m);
    else return 0;
}

Console.WriteLine(SequenceOfNumbers(numberOne, numberTwo));