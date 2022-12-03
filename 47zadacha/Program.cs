// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("введите размерность двумерного массима m x n");
Console.Write("введите m(строку): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите n(столбец): ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[m, n];


for(int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2); // [1, 10)
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}