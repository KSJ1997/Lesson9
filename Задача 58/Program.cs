// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int size = InputInt("Введите размер матрицы: ");
int[,] matrixOne = new int[size, size];
int[,] matrixTwo = new int[size, size];
int[,] matrixFull = new int[size, size];

ArrayRandomNumber(matrixOne);
ArrayRandomNumber(matrixTwo);
void ArrayRandomNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

Console.WriteLine("Первая матрица: ");
PrintArray(matrixOne);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrixTwo);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");

MatrixResult(matrixFull);
void MatrixResult(int[,] array)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixFull[i, j] = matrixFull[i, j] + (matrixOne[i, k] * matrixTwo[k, j]);
            }
        }
    }
}
PrintArray(matrixFull);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}