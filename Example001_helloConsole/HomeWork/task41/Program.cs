// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Вводитe сколько угодно цифр через пробел");
Console.Write("\n");
long countOfPositiveNumbers = 0;
string input = Console.ReadLine();


for (int i = 0; i < input.Length; i++) 
{
    if (input[i] == 48 && i < input.Length - 1)
    {
        while (input[i] == 48 && i < input.Length - 1) i++;
    }
    if (input[i] >= 49 && input[i] <= 57) countOfPositiveNumbers++;
    if (input[i] == 45 && i < input.Length - 1) i++;
    while ((input[i] >= 48 && input[i] <= 57)
            && i < input.Length - 1) i++;
}
Console.Write("\n");
 Console.WriteLine("Количество чисел больше нуля - {0}.", countOfPositiveNumbers);
 Console.Write("\n");
 Console.WriteLine("Получилась переменная типа String?  - Да");
 Console.Write("\n");
 Console.WriteLine("Поискали в интернете метод для парсинга строки в массив чисел через сеператор(разделитель) - Нет  ");
 Console.Write("\n");
 Console.WriteLine("Прошлись по данному массиву и посчитали  колличество положительных чисел?  - Да, несколько раз");
 Console.Write("\n");

