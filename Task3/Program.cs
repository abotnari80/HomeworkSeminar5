int result = 0;
int minValue = 101;
int maxValue = 0;
int[] array = new int[4];

for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(-100, 100);
    System.Console.Write($"{array[i]} ");
}

System.Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    if (maxValue < array[i])
    {
        maxValue = array[i];
    }
    
    if (minValue > array[i])
    {
        minValue = array[i];
    }
}

result = maxValue - minValue;
System.Console.WriteLine(result);