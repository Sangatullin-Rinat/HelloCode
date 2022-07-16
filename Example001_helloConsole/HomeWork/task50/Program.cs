// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Enter M and N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());   


int[,] array = new int [M,N]; 

Random rnd = new Random(); 

for (int i = 0; i < M; i++) {
    for (int j = 0; j < N; j++) {
         array [i,j] = rnd.Next(-10, 10);

        Console.Write(array[i,j]+ " ");
     }
    Console.WriteLine();
}
for (int j = 0; j < N; j++) {
    double sum = 0;
    for (int i = 0; i < M; i++) {
        sum += array[i, j];
    }
     Console.WriteLine("sum is {0}", sum / M);
}