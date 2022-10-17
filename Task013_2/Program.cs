
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void returnThirdDigit(int userNumber)
{
    if (userNumber / 100 == 0)
    {
        Console.WriteLine($"В введённом числе третьей цифры нет");
        //здесь можно поставить return; тогда цикл while можно использовать не в блоке else.
        //но я не знаю как привильнее относительно данного решения
    }
    else
    {
        while (true)// запускаем бесконечный цикл, т.к. заранее длина числа неизвестна
        {
            //у трёхзначного числа сотни должны быть, но не более 9 включительно.
            if (userNumber / 100 > 0 && userNumber / 100 <= 9)
            {
                break;
            }
            userNumber /= 10;
        }
        Console.WriteLine($"В введённом числе третья цифра равна {userNumber % 10}");
    }
}

int userDigit;
Console.Write("Введите число: ");
userDigit = int.Parse(Console.ReadLine()!);

returnThirdDigit(userDigit);
