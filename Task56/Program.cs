void InputMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

void CountMatrixSum(int [,] matrix)
{
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"В строке {i + 1} сумма элементов равна {sum}\n");
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма {minSum} в строке {minRow}");
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0],size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
CountMatrixSum(matrix);