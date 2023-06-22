// Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} ");
        System.Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
    
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
            if (array[i, k] < array[i, k + 1])
            {
                int buf = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = buf;
            }
            
        }
        System.Console.WriteLine();
        }
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);

SortArray(array);
PrintArray(array);