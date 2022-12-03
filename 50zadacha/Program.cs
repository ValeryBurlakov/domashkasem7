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
int [,] indexMatrix = new int[m, n];
int[] arr = new int[m];
for(int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10); // [1, 10)
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

// Console.WriteLine("введите размерность двумерного массива m x n");
// Console.Write("введите m(строку): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите n(столбец): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m, n];
Console.WriteLine();

int t = 1;
for(int i = 0; i <m; i++)
{
    
    for (int j = 0; j < n; j++)
    { 
        
        indexMatrix[i, j] = indexMatrix[i, j] + t; // [1, 10)
        Console.Write(indexMatrix[i, j] + " ");
        t++;
    }
    
    Console.WriteLine();
}

Console.WriteLine("Введите порядковый номер элемента(1, 2, 3, 4....");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int number1 = 0;
for(int i = 0; i <m; i++)
{
    
    for (int j = 0; j < n; j++)
    { 
        
        if (number == indexMatrix[i, j])
        { 
            number1 = number;
            while (number1 > n)
            {
                // count++;
                number1 = number1 / n;
                count++;

                Console.WriteLine(indexMatrix[number1, 1]);
            }
        }
        arr[i] = indexMatrix[number1, i];
        Console.Write(arr);
    }
    // Console.WriteLine();
}
Console.WriteLine(number1);




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