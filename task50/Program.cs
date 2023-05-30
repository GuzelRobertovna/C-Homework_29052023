// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int[,] array = new int[rows, columns];
FillArray(array, rows, columns, 0, 30);
Console.WriteLine("Заданный массив: ");
PrintArray(array);
int position1 = Prompt("Введите первую позицию элемента масива: ");
int position2 = Prompt("Введите вторую позицию элемента масива: ");
ElementsPosition(array, position1, position2);


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

void ElementsPosition(int[,] matrix, int pos1, int pos2)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == pos1 && j == pos2) count++;
        }
    }
    if (count == 0) Console.WriteLine("Элемента с такой позицией нет ");
    else Console.WriteLine($"Значение элемента с позицией [{pos1},{pos2}] = {matrix[pos1, pos2]}");
}