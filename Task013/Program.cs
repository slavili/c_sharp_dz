
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void returnThirdDigit(int userNumber)
{
    string tempStr = userNumber.ToString();
    char[] tempArray = tempStr.ToCharArray();

    if (tempArray.Length >= 3)
    {
        Console.WriteLine($"Третья цифра числа {userNumber} равна {tempArray[2]}");
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}

int userNumber;// число введённое пользователем

Console.Write("Введите число: ");
userNumber = int.Parse(Console.ReadLine()!);

returnThirdDigit(userNumber);