/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
//Обычная рекурсия
int GetSumNaturalNumbers1(int beginNumber, int endNumber)
{
    if (endNumber == beginNumber)
    {
        return endNumber;
    }
    return beginNumber + GetSumNaturalNumbers1(beginNumber + 1, endNumber);
}
//хвостовая рекурсия - насколько я её понимаю
int GetSumNaturalNumbers2(int beginNumber, int endNumber, int sum = 0)
{
    if (beginNumber > endNumber)
    {
        return sum;
    }
    return GetSumNaturalNumbers2(beginNumber + 1, endNumber, sum + beginNumber);
}


Console.Write("Введите начальное число: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел от {start} до {stop} (1-я реализация): " + GetSumNaturalNumbers1(start, stop));
Console.WriteLine($"Сумма чисел от {start} до {stop} (2-я реализация): " + GetSumNaturalNumbers2(start, stop));