int result = 0;
int[] array = new int[4];

for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(-100, 100);
    System.Console.Write($"{array[i]} ");
}

System.Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    if ((i + 1) % 2 != 0)
    {
        result = result + array[i];
    }
}

System.Console.WriteLine(result);