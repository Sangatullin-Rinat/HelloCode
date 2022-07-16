// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами m = 3, n = 4.

Console.WriteLine("Enter M and N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());   

Console.WriteLine("Enter i0 and j0");
int i0 = Convert.ToInt32(Console.ReadLine());
int j0 = Convert.ToInt32(Console.ReadLine());  

int[,] array = new int [M,N]; 

Random rnd = new Random(); 

for (int i = 0; i < M; i++) {
    for (int j = 0; j < N; j++) {
         array [i,j] = rnd.Next(-10, 10);

        Console.Write(array[i,j]+ " ");
     }
    Console.WriteLine();
}

if (i0 >= M || j0 >= N || i0 < 0 || j0 < 0){
     Console.WriteLine("Out if range");
} else {
         Console.WriteLine("Element with j=j0 and i=10 is {0}", array [i0,j0]);
}