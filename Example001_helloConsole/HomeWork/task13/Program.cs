// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void hasThirdNumber(int x) {
int div = 1;
while (x / div >= 10) {
div *= 10;
}

if (div < 100) {
    Console.WriteLine("Too little number");
} else {
    // last number of x / (div/100)    123456
    int digit = (x / (div/100)) % 10;
    Console.WriteLine("Third is {0}", digit);
}
}

hasThirdNumber(12);
hasThirdNumber(123);