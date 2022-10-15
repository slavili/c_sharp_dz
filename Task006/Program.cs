/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

int userNumber; // число введённое пользователем

Console.Write("Введите число: ");
userNumber = int.Parse(Console.ReadLine()!);

if (userNumber % 2 == 0)
{
    Console.WriteLine($"Число {userNumber} чётное.");
}
else
{
    Console.WriteLine($"Число {userNumber} НЕ чётное.");
}