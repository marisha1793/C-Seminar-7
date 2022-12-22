// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Задан двумерный массив: ");
int m = 3;
int n = 4;
int[,] array = Create2DArray(m,n);
Print2DArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
GetMeanOfColumns(array);

void GetMeanOfColumns(int[,] array)
{
    double sum = 0;
    int count = 0;
    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
            count++;
        }
        Console.Write(sum / count + "; ");
        sum = 0;
        count = 0;
    }

}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
}