int result = 0;
int[] array = new int[4];

for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(100, 999);
    System.Console.Write($"{array[i]} ");
}

System.Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    if (array[i] % 2 == 0)
    {
        result = result + 1;
    }
}

System.Console.WriteLine(result);