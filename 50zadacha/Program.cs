// Задача 50. Напишите программу, 
// которая на вход принимает позиции 
// элемента в двумерном массиве, и 
// возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("введите размерность двумерного массима m x n");
// Console.Write("введите m(строку): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите n(столбец): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m, n];


// for(int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10); // [1, 10)
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Repeat:
// Console.WriteLine("Введите позицию элемента. Начинается с [1, 1]: ");
// Console.WriteLine("Введите M");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > 0 && b > 0)
// {
//     if (a > m || b > n)
//         Console.WriteLine("такого числа нет");
//     else
//     {

//         Console.WriteLine(matrix[a - 1, b - 1]);
//     }
// }
// else
// {
//     Console.WriteLine("вы ввели координаты неправильно, повторите попытку:");
//     goto Repeat;
// }




Console.WriteLine("введите размерность двумерного массима m x n");
Console.Write("введите m(строку): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите n(столбец): ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m, n];
Console.WriteLine("Двумерный массив");
for(int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10); // [1, 10)
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int q = matrix.GetLength(0) * matrix.GetLength(1);
int[] arr = new int[q];
int k = 0;
Console.WriteLine("преобразовали в одномерный массив");
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arr[k] = matrix[i, j];
        // Console.Write($"{arr[k]}" + " "); // вывод одномерного массива
        k++;
    }
    
}

Console.WriteLine("Введите позицию элемента начиная с 1.");
int position = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Число на {position} позиции это {arr[position - 1]}");



