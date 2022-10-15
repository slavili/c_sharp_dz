/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int counter = 2; // Счётчик циклов, шаг будет равен 2, т.к. нужны чётные числа
int userNumber; // число введённое пользователем
string result = ""; // результирующая строка со всеми чётными числами разделёнными пробелом

Console.Write("Введите число: ");
userNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Все чётные цифры от 1 до {userNumber}");

while (counter <= userNumber)
{
    result += counter.ToString() + " ";
    counter += 2;
}

Console.WriteLine(result);