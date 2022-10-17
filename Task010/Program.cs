/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
забронируем переменную, в которую пользователь будет вводить число
с помощью консоли.
*/
int testDigit;

/*
в функции TestThreeDigitNumber проверяем есть ли сотни
и этих сотен должно быть не более 9-ти - это залог трёзначности
*/
bool TestThreeDigitNumber(int uNumber)
{
    uNumber /= 100;
    if (uNumber > 0 && uNumber <= 9)
    {
        return true;
    }
    return false;
}
// функция returnSecondDigit извлекает вторую цифру
int returnSecondDigit(int userNumber)
{
    return (userNumber / 10) % 10;
}

Console.Write("Введите трёхначное целое число: ");
testDigit = int.Parse(Console.ReadLine()!);

if (TestThreeDigitNumber(testDigit))
{
    Console.WriteLine(returnSecondDigit(testDigit));
}
else
{
    Console.WriteLine($"Число {testDigit} не является трёхзначным");
}


/*
    do
    {
        Console.WriteLine("Введите трёхзначное целое число:");
    }
    while (userNumber % 100 > 0 && userNumber % 100 <= 9);
*/