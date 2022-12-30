// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

PrintArray(num);
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

MinSumArray(num);
void MinSumArray(int[,] array)
{
    int minSum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < num.GetLength(1); j++)
        {
            sum = sum + num[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов равная {minSum}, находится в строке c номером {indexLine}.");
}
