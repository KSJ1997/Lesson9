// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];


ArrayRandomNumber(num);
void ArrayRandomNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.WriteLine("Задан массив:");
PrintArray(num);
SortedArray(num);
void SortedArray(int[,] array)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < num.GetLength(1) - 1; z++)
            {
                if (num[i, z] < num[i, z + 1])
                {
                    int temp = 0;
                    temp = num[i, z];
                    num[i, z] = num[i, z + 1];
                    num[i, z + 1] = temp;
                }
            }
        }
    }
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
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(num);
