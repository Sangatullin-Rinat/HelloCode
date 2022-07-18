// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillIntTable(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintIntTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        int j = 0;
        while (j < array.GetLength(1))
        {
            Console.Write(array[i, j]);
            j++;
            if (j < array.GetLength(1)) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}



Console.Write("\n");
int[,] twoDimensionArray = new int[new Random().Next(2, 10), new Random().Next(2, 10)];
FillIntTable(twoDimensionArray, -100, 100);
Console.WriteLine("Задан двумерный массив из целых чисел в виде таблицы:");
Console.Write("\n");
PrintIntTable(twoDimensionArray);

double averageValueInColumn;
Console.Write("\n");
Console.WriteLine("Среднее арифметическое каждого столбца:");
Console.Write("\n");
Console.Write("[");

for (int column = 0; column < twoDimensionArray.GetLength(1); column++)
{
    averageValueInColumn = 0;
    for (int row = 0; row < twoDimensionArray.GetLength(0); row++)
    {
        averageValueInColumn += twoDimensionArray[row, column];
    }
    averageValueInColumn /= twoDimensionArray.GetLength(0);
    Console.Write(averageValueInColumn);
    if (column < twoDimensionArray.GetLength(1) - 1) Console.Write(",");
}
Console.WriteLine("]");
Console.Write("\n");