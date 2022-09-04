// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Задача 54.");

Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Massiv = new int[m, n];

CreateArray(m, n, ref Massiv);

Console.WriteLine($"\nВаш массив: ");
Print(Massiv);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(Massiv);
WriteArray(Massiv);

void CreateArray(int m, int n, ref int[,] Massiv)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"/nВведите {i + 1} строку: ");
        string? Array = Console.ReadLine();
        Array = Array.Replace(",", "");
        Array = Array.Replace(".", "");

        string[] arr = Array.Split(" ");
        for (int j = 0; j < n; j++)
        {
            Massiv[i, j] = Convert.ToInt32(arr[j]);
        }
    }
}

void Print(int[,] Massiv)
{
    for (int i = 0; i < Massiv.GetLength(0); i++)
    {
        for (int j = 0; j < Massiv.GetLength(1); j++)
        {
            Console.Write($"{Massiv[i, j]} ");
        }
        Console.WriteLine();
    }
}

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}