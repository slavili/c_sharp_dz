/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int firstNumber, secondNumber, thirdNumber, maxNumber;

Console.Write("Введите первое число: ");
firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
secondNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
thirdNumber = int.Parse(Console.ReadLine()!);

maxNumber = firstNumber;

if (maxNumber < secondNumber)
{
    maxNumber = secondNumber;
}
if (maxNumber < thirdNumber)
{
    maxNumber = thirdNumber;
}

Console.WriteLine($"Максимальное число равно {maxNumber}");