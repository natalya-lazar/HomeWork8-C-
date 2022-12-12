//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
//Решение:

/*int [,] Create2dArray(int row, int column, int minValue, int maxValue)
{
    int [,] created2dArray = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return created2dArray;
}
void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] Odered2dArray(int[,] createdArray)
{
    for (int i = 0; i < createdArray.GetLength(0); i++)
    {
        for (int k = 1; k < createdArray.GetLength(1); k++)
        {
            for (int j = 0; j < createdArray.GetLength(1) - 1; j++)
            {
                if (createdArray[i, j] > createdArray[i, j + 1])
                {
                    int temp = createdArray[i, j];
                    createdArray[i, j] = createdArray[i, j + 1];
                    createdArray[i, j + 1] = temp;
                }
            }
        }
    }
    return createdArray;
}
Console.WriteLine("Введите количество строк массива: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива: ");
int nuser_minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());
int [,] created2dArray = Create2dArray(user_rows, user_columns, nuser_minValue, user_maxValue);
Show2dArray(created2dArray);
Console.WriteLine();
Show2dArray(Odered2dArray(created2dArray));
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
//элементов: 1 строка
//Решение:

/*int [,] Create2dArray(int row, int column, int minValue, int maxValue)
{
    int [,] created2dArray = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return created2dArray;
}
void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[] SummRowElements(int[,] array)
{
    int[] array_sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        array_sum[i] = sum;
    }
    return array_sum;
}
void FindIndexMinRowSum(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {index}");
}
Console.WriteLine("Введите количество строк массива: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива: ");
int nuser_minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());
int [,] created2dArray = Create2dArray(user_rows, user_columns, nuser_minValue, user_maxValue);
Show2dArray(created2dArray);
int [] new_array_sum = SummRowElements(created2dArray);
FindIndexMinRowSum(new_array_sum);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
//Решение:

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateSpiralArray(int row, int column)
{
    int[,] spiralArray = new int[row, column];
    int k = 11;
    int iMin = 0;
    int jMin = 0;
    int iMax = row;
    int jMax = column;
    while (iMin < iMax && jMin < jMax)
    {
        int i = iMin;
        int j = jMin;
        for (j = jMin; j < jMax; j++)
        {
            spiralArray[i, j] = k;
            k++;
        }
        j = jMax - 1;
        for (i = iMin + 1; i < iMax; i++)
        {
            spiralArray[i, j] = k;
            k++;
        }
        i = iMax - 1;
        for (j = jMax - 2; j >= jMin; j--)
        {
            spiralArray[i, j] = k;
            k++;
        }
        j = jMin;
        for (i = iMax - 2; i > iMin; i--)
        {
            spiralArray[i, j] = k;
            k++;
        }
        iMin++;
        jMin++;
        iMax--;
        jMax--;
    }
    return spiralArray;
}
Console.WriteLine("Введите количество строк массива: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
int [,] Spiral = CreateSpiralArray(user_rows, user_columns);
Show2dArray(Spiral);

//Задача 58(дополнительно): Задайте две матрицы. Напишите программу, которая будет находить
//произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)