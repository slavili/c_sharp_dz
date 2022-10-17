/*
Дополнительная Задача 9
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет
46 -> нет
161 -> да
*/
//Забронируем переменную для пользовательского ввода данных
int uNumber;

void MultiplicityTwoDigits(int userNumber, int oneNumber = 7, int twoNumber = 23)
{
    if (userNumber % oneNumber == 0 && userNumber % twoNumber == 0)
    {
        Console.WriteLine($"Число {userNumber} кратно одновременно обоим числам: {oneNumber} и {twoNumber}");
    }
    else
    {
        Console.WriteLine($"Число {userNumber} не является кратным одновременно обоим числам: {oneNumber} и {twoNumber}");
    }
}


Console.Write("Введите чило для проверки кратности: ");
uNumber = int.Parse(Console.ReadLine()!);

MultiplicityTwoDigits(uNumber);