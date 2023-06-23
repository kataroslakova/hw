// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
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

void ProductMatrix(int [,] array1, int [,] array2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < result.GetLength(1); k++)
            {
                sum += array1[i,k]*array2[k,j];
            }
            result[i,j] = sum;
        }
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк первой матрицы ");
int rows1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов первой матрицы, строк второй ");
int cols1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов второй матрицы ");
int cols2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[rows1, cols1];
int[,] array2 = new int [cols1, cols2];
int[,] result = new int [rows1, cols2];


FillArray(array1);
PrintArray(array1);
System.Console.WriteLine();
FillArray(array2);
PrintArray(array2);
System.Console.WriteLine();
ProductMatrix(array1,array2,result);
PrintArray(result);