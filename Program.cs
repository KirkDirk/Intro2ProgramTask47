// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray2DimRandomRealNumbers(int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(1, 20) - 10;
        }
    }
    return array;
}
void PrintArray2Dim(double[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write("{0,5:N1}", someArray[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.WriteLine("Введите число, равное числу строк в массиве:");
int countRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, равное числу столбцов в массиве:");
int countColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Массив {countRow}x{countColumn} из случайных вещественных чисел да будет таков:");
PrintArray2Dim(CreateArray2DimRandomRealNumbers(countRow, countColumn));