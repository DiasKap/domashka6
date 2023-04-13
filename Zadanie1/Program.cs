Console.WriteLine("Числа через пробел: ");
string[] array = Console.ReadLine().Split(' ');

int Count(string[] array)
{
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.Parse(array[i]) > 0) c++;
    }

    return c;
}
Count(array);

Console.WriteLine(String.Join(" / ", array));
Console.WriteLine(Count(array));    