// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите трехзначное число - ");
long number = Convert.ToInt64(Console.ReadLine());
if (number < 0)
{
    number = -number;
}

if (number < 100)
{
    Console.WriteLine("нет третьей цифры");
}
else
{
    number = number / 100;
    Console.WriteLine(number % 1);
}