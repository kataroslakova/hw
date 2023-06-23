// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void SumArray(int[,] array)
{
    int MinRow = 0;
    int MinSum = 0;
    int SumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        MinRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) SumRow += array[i, j];
        if (SumRow < MinRow)
        {
            MinRow = SumRow;
            MinSum = i;
        }
        SumRow = 0;
    }
    Console.WriteLine($"{MinSum + 1} строка с наименьшей суммой");
}




Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine("");
SumArray(array);

