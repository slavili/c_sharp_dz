/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
// забронируем переменную для пользовательского ввода номера дня недели.
byte dayOfWeek;

void testDayOfWeek(byte userNumber)
{
    if (userNumber == 6 || userNumber == 7)
    {
        Console.WriteLine($"{userNumber}-й день недели является выходным.");
    }
    else if (userNumber >= 1 && userNumber <= 5)
    {
        Console.WriteLine($"{userNumber}-й день недели является рабочим днём.");
    }
    else
    {
        Console.WriteLine($"Дня недели с номером {userNumber} не существует.");
    }
}


do
{
    Console.Write("Введите номер дня недели: ");
    dayOfWeek = byte.Parse(Console.ReadLine()!);
    testDayOfWeek(dayOfWeek);
}
while (dayOfWeek >= 1 && dayOfWeek <= 7);
