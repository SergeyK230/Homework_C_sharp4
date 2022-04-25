int Stepen (int osnova, int stepen)
{
    int result = 1;
    for (int i = 0; i < stepen; i++)
    {
        result = result * osnova;
    }
    return result;
}

System.Console.WriteLine(Stepen(3, 5));
