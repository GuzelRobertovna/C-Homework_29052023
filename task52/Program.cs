// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int[,] array = new int[rows, columns];
FillArray(array, rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray2(SredArifmet(array));

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

void FillArray(int[,] matrix, int m, int n, int minValue, int maxValue)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}  ");
        }
        Console.WriteLine();

    }
}

double[] SredArifmet(int[,] matrix1)
{
    double[] resultArray = new double[matrix1.GetLength(1)];
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            sum += matrix1[i, j];
        }
        resultArray[j] = Math.Round((sum / matrix1.GetLength(0)), 2);
    }
    return resultArray;
}

void PrintArray2(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"[{matrix[i]}]  ");
    }
    Console.WriteLine();
}
