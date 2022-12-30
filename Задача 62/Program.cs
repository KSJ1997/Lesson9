// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];

int num = 1;
int i = 0;
int j = 0;

HelicalArrayFilling(numbers);
void HelicalArrayFilling(int[,] array)
{

    while (num <= m * n)
    {
        numbers[i, j] = num;
        if (i <= j + 1 && i + j < m - 1)
            ++j;
        else if (i < j && i + j >= n - 1)
            ++i;
        else if (i >= j && i + j > m - 1)
            --j;
        else
            --i;
        ++num;
    }
}


PrintArray(numbers);
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