// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int[,] GenerateArray(int rows = 3, int cols = 4 ,int start = 0, int end = 100)
// {
//     int[,] array = new int[rows,cols];
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = random.Next(start, end);
//         }
//     }

//     return array;
// }


// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }


    
// }



// //Чтение данных из консоли
// Console.Write("Введите количество строк для генерации массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов для генерации массива: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] userArray = GenerateArray(rows, cols);
// PrintArray(userArray);

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int InputNumber()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// void CraeteArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = i + j;
//         }
//     }
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите число M: ");
// int row = InputNumber();
// Console.Write("Введите число N: ");
// int colums = InputNumber();

// int[,] array = new int[row, colums];
// CraeteArray(array);
// PrintArray(array);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int InputNumber()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// void CraeteArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void ChangeSquere(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0){
//                 arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
//             }
//         }
//     }
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите число M: ");
// int row = InputNumber();
// Console.Write("Введите число N: ");
// int colums = InputNumber();

// int[,] array = new int[row, colums];
// CraeteArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangeSquere(array);
// PrintArray(array);


// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int EnterNumber() // метод для ввода числа, значения 
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// //EnterNumber();
// void NewArray(int[,] array) //Метод создания массива, значение рандома задает клиент. 
// {
//     Console.Write("Создать массив из случайных чисел [мин, макс]. Введите минимальное значение = ");
//     int min = EnterNumber();
//     Console.Write("Создать массив из случайных чисел [мин, макс]. Введите масимальное значение = ");
//     int max = EnterNumber();
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         // array[i] = new Random().Next(min, max);
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
    
    
// }
// // int[,] array = new int[3, 4];
// // NewArray(array); // вызов метода создания массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // PrintArray(array);

// // string[,] table = new string[2,3];
// void SummDiagonal(int[,] array)
// {
//     int summ =0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 summ = summ + array[i, j];
//             }
//             // Console.Write($"{array[i, j]} ");
            
//         }
        
//     }
//     Console.WriteLine(summ);
// }


// int[,] array = new int[3, 3];
// NewArray(array); // вызов метода создания массива
// PrintArray(array);
// SummDiagonal(array);


// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}
void ReversLine(int[,] mass)
{
    int Temp = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (i == 0 || i == mass.GetLength(0))
            {
                Temp = mass[i, j];
                mass[i, j] = mass[mass.GetLength(0) - 1, j];
                mass[mass.GetLength(0) - 1, j] = Temp;
            }
        }
    }
}
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ReversLine(int[,] mass) Дополнительный метод переназначение элементов!
// {
//     for (int j = 0; j < mass.GetLength(1); j++)
//     {
 //         (mass[0, j], mass[mass.GetLength(0) - 1, j]) = (mass[mass.GetLength(0) - 1, j], mass[0, j]);
//     }
// }

// Console.Write("Введите число M: ");
// int row = InputNumber();
// Console.Write("Введите число N: ");
// int colums = InputNumber();

// int[,] array = new int[row, colums];
// CraeteArray(array);
// PrintArray(array);
// Console.WriteLine();
// ReversLine(array);
// PrintArray(array);