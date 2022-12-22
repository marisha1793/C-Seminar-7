// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Задан двумерный массив: ");
int m = 3;
int n = 4;
int[,] array = Create2DArray(m,n);
Print2DArray(array);
Console.WriteLine("Введите позиции элемента в двумерном массиве. Сначала позицию строчки: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Теперь позицию столбца: ");
int j = int.Parse(Console.ReadLine());

if (i < array.GetLength(0) && j < array.GetLength(1))
{
    Console.WriteLine($"Искомое число равно {array[i,j]}");
} 
else 
{
    Console.WriteLine("Такого числа в массиве нет");
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

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }
    
    throw new Exception("Введены не корректные символы");
}