// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Enter X and Y");
int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());   
Console.Write("\n");


int[,] array = new int [X,Y]; 

Random rnd = new Random(); 

for (int i = 0; i < X; i++) {
    for (int j = 0; j < Y; j++) {
         array [i,j] = rnd.Next(-10, 10);

        Console.Write(array[i,j]+ " ");
     }
    Console.WriteLine();
    Console.Write("\n");
}
for (int j = 0; j < Y; j++) {
    double sum = 0;
    for (int i = 0; i < X; i++) {
        sum += array[i, j];
    }
     Console.WriteLine("sum is {0}", sum / X);
     Console.Write("\n");
}