// Задача 29; Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine(" от -500000 до -500000.");
Console.WriteLine();
void FillIntArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-500000, 500001);
    }
}

void PrintIntArray (int[] array)
{
    Console.Write("[");
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i]);
        i++;
        if (i < array.Length)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] array = new int[8];

FillIntArray(array);
PrintIntArray(array);