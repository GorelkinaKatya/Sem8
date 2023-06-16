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
    Console.WriteLine();
}

void CountMatrixMult(int [,] matrixA, int [,] matrixB, int [,] result)
{ 
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
            result[i, j] = matrixA[i, j] * matrixB[i, j];
    }
}

Console.Clear();
Console.Write("Введите размеры матриц: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[size[0],size[1]];
int[,] matrixB = new int[size[0],size[1]];
InputMatrix(matrixA);
InputMatrix(matrixB);
Console.WriteLine("Матрица А:");
PrintMatrix(matrixA);
Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);
int[,] result = new int[size[0],size[1]];
CountMatrixMult(matrixA, matrixB, result);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(result);