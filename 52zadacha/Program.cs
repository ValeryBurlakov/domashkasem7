// Задача 52. Задайте двумерный массив 
// из целых чисел. Найдите среднее 
// арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите размерность двумерного массима m x n");
Console.Write("введите m(строку): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите n(столбец): ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m, n];
double sum = 0;

for(int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10); // [1, 10)
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое каждого столбца:");

for (int j = 0; j < n; j++)
{
    sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += matrix[i, j];
    }
    double average = sum / m;
    Console.WriteLine($"столбец {j + 1}: " + Math.Round(average, 2) + "; ");
}