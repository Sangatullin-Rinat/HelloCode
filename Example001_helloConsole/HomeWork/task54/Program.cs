// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            if (j < array.GetLength(1)) Console.Write(",");
        }
        Console.WriteLine("]");
    }
}

void SwapElementsIn2DIntArray(int[,] twoDimensionIntArray, int firstIndexOf1Element, int secondIndexOf1Element,
int firstIndexOf2Element, int secondIndexOf2Element)
{
        int tempValue = twoDimensionIntArray[firstIndexOf1Element, secondIndexOf1Element];
        twoDimensionIntArray[firstIndexOf1Element, secondIndexOf1Element] = twoDimensionIntArray[firstIndexOf2Element, secondIndexOf2Element];
        twoDimensionIntArray[firstIndexOf2Element, secondIndexOf2Element] = tempValue;
}

Console.WriteLine("Програма генерирует таблицу.");
int[,] twoDimensionArray = new int[new Random().Next(2, 11), new Random().Next(3, 11)];
FillIntTable(twoDimensionArray, -88, 101);
Console.WriteLine("Сгенерирован следующий массив:");
PrintIntTable(twoDimensionArray);

int indexOfCurrentMax = 0;
int indexOfCurrentMin = 0;

for (int i = 0; i < twoDimensionArray.GetLength(0); i++)
{
    for (int j = 0; j < twoDimensionArray.GetLength(1)/2; j++)
    {
        indexOfCurrentMax = j;
        indexOfCurrentMin = j;
        for (int k = j; k < twoDimensionArray.GetLength(1) - j; k++)
        {
            if (twoDimensionArray[i, indexOfCurrentMax] < twoDimensionArray[i, k]) indexOfCurrentMax = k;
            if (twoDimensionArray[i, indexOfCurrentMin] > twoDimensionArray[i, k]) indexOfCurrentMin = k;
        }
        SwapElementsIn2DIntArray(twoDimensionArray,i,indexOfCurrentMax,i,twoDimensionArray.GetLength(1)-1-j);
        if (indexOfCurrentMin == twoDimensionArray.GetLength(1)-1-j) indexOfCurrentMin = indexOfCurrentMax;
    
        SwapElementsIn2DIntArray(twoDimensionArray,i,indexOfCurrentMin,i,j);
    }
}

