// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

//                                         Например, задан массив:
//                                         1 4 7 2
//                                         5 9 2 3
//                                         8 4 2 4
//                                         Среднее арифметическое каждого
//                                         столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] GetArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = Math.Round(sum / array.GetLength(0), 2);
        }
    }
    return result;
}

void PrintArithmeticMean(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(row, col, 1, 10);
double[] result = GetArithmeticMean(matrix);

PrintArray(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
PrintArithmeticMean(result);