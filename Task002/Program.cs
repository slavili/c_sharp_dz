/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int firstNumber;  // первое число введённое пользователем
int secondNumber; // второе число введённое пользователем

Console.Write("Введите первое число: ");
firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
secondNumber = int.Parse(Console.ReadLine()!);

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число {firstNumber} больше второго числа {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"Второе число {secondNumber} больше первого {firstNumber}");
}
else
{
    Console.WriteLine($"Оба числа равны {firstNumber} = {secondNumber}");
}