void Vvod (int[] array)
{
    Console.WriteLine("Введите элементы массива через Enter");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

void Print (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите количество элементов в массиве");
int coll = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[coll];
Vvod(arr);
Print(arr);
