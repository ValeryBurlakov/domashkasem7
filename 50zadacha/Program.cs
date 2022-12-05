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

Repeat2:
Console.WriteLine("1 - поиск элемента по номеру позиции, 2 - поиск по индексу:");
int answer = Convert.ToInt32(Console.ReadLine());

if (answer == 1 || answer == 2)
{
    if (answer == 2)
    {
        Console.WriteLine("введите размерность двумерного массима m x n");
        Console.Write("введите m(строку): ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите n(столбец): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [,] matrix = new int[m, n];


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
    Repeat:
    Console.WriteLine("Введите позицию элемента. Начинается с [1, 1]: ");
    Console.WriteLine("Введите M(строку)");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N(столбец)");
    int b = Convert.ToInt32(Console.ReadLine());

        if (a > 0 && b > 0)
        {
            if (a > m || b > n)
                Console.WriteLine("такого числа нет");
            else
                {

                    Console.WriteLine($"ваше число с индексом " + (a, b) + " это: " + (matrix[a - 1, b - 1]));
                }
        }
        else
        {
            Console.WriteLine("вы ввели координаты неправильно, повторите попытку:");
            goto Repeat;
        }

    }



    if (answer == 1)
    {
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
                matrix[i, j] = new Random().Next(1, 10);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int q = matrix.GetLength(0) * matrix.GetLength(1);
        int[] arr = new int[q];
        int k = 0;
        // Console.WriteLine("преобразовали в одномерный массив");

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
        Console.WriteLine("---------------------------------------------");
        if (position <= q && position > 0)
        {
            Console.WriteLine($"Число на {position} позиции это: {arr[position - 1]}");
        }
        else if (position > q)
        {
            Console.WriteLine($"Максимальная позиция нашего массива = {q}.");
            Console.WriteLine("Такого элемента не существует");
        }
        else if (position < 1)
        {
            Console.WriteLine("Позиция начинается с 1, такого элемента нет");
        }
        Console.WriteLine("---------------------------------------------");
    }
}
else
{
    Console.WriteLine("Вы ввели неправильно, повторите попытку");
    goto Repeat2;
}


