int[] RandArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(' ');
    }
    Console.WriteLine();
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел 
//в массиве.
int ChetNum(int[] array)
{
    int score = 0;
    for (int i = 0; i < array.Length ; i++)
    {
        if (array[i] % 2 == 0)
        {
            score++;
        }
    }
    return score;
}

// int []array = RandArray(4, 100, 999);
// WriteArray(array);
// Console.WriteLine(ChetNum(array));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int NechSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum += array[i];
    }
    return sum;
}

// int []array = RandArray(10, 0, 10);
// WriteArray(array);
// Console.WriteLine(NechSum(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
double RandRealNumder(int min, int max, int amount)
{
    Random rand = new Random();
    double fractionPart = rand.NextDouble();
    int wholePart = rand.Next(min, max);
    double result = Math.Round(wholePart + fractionPart, amount);
    return result;
}

double[] RandDoubleArray(int len, int min, int max)
{
    double[] array = new double[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = RandRealNumder(min, max, 2);
    }
    return array;
}

void WriteDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(' ');
    }
    Console.WriteLine();
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
double[] array = RandDoubleArray(5, -100, 100);
WriteDoubleArray(array);
Console.WriteLine(MaxNumber(array) - MinNumber(array));
