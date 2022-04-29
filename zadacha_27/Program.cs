int Summa(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return Math.Abs(result);
}

System.Console.WriteLine(Summa(-9012));
