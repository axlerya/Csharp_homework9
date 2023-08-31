Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

string SequenceOfNumbers(int n)
{
    if (n > 0) return $"{n} " + SequenceOfNumbers(n - 1);
    else return string.Empty;
}

Console.Write(SequenceOfNumbers(number));
