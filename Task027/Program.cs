/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int sumOfDigits(int userNumber)
{
    int resultSum = 0;

    //число будет взято по модулю
    userNumber = Math.Abs(userNumber);

    while (userNumber > 0)
    {
        resultSum += userNumber % 10;
        userNumber /= 10;
    }

    return resultSum;
}
Console.Write("Введите число(будет использован модуль): ");
int uNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {uNumber} равна: " + sumOfDigits(uNumber));

