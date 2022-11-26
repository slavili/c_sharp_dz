/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

double GetNumberOfAkkerman(double m = 3, double n = 2)
{
    if (m > 0 && n > 0)
    {
        return GetNumberOfAkkerman(m - 1, GetNumberOfAkkerman(m, n - 1));
    }
    else if (m > 0 && n == 0)
    {
        return GetNumberOfAkkerman(m - 1, 1);
    }
    else if (m == 0)
    {
        return n + 1;
    }
    return -1;
}

Console.WriteLine("Вычисление функции Аккермана.");
Console.Write("Введите m: ");
double m = double.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
double n = double.Parse(Console.ReadLine()!);
Console.WriteLine(GetNumberOfAkkerman(m, n));