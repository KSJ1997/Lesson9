// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine($"Сформирован трёхмерный массив из неповторяющихся двузначных чисел.");
int[,,] array3D = CreateMatrix(2, 2, 2, 10);
int[,,] CreateMatrix(int Matrix1, int Matrix2, int Matrix3, int index)
{
    var matrix = new int[Matrix1, Matrix2, Matrix3];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = index + 1;
                index = matrix[i, j, k];
            }
        }
    }
    return matrix;
}

PrintMatrix(array3D);
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],4}({i},{j},{k}), ");
                else if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],4}({i},{j},{k}), ");
                else Console.Write($"{matrix[i, j, k],4}({i},{j},{k}) ");
            }
        }
        Console.WriteLine("|");
    }
}
