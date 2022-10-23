/*
Дополнительно.
Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11
*/

void tableOfSimpleNumber(int numericalBorder)
{
    //первый цикл предоставлят ряд чисел для проверки: простое, не простое.
    for (int currentNumber = 2; currentNumber <= numericalBorder; currentNumber++)
    {
        bool isSimple = true;//флаг: если после второго цикла останется true - число простое

        //в переменную помещая границу ряда чисел, которые будут делителями.
        int countOfCycle = Convert.ToInt32(Math.Sqrt(currentNumber));

        for (int divisor = 2; isSimple && divisor <= countOfCycle; divisor++)
        {
            //если хотя бы один остаток от деления будет равен нулю,
            //то isSimple=false - число не простое и сразу прерываем цикл
            isSimple = currentNumber % divisor != 0;
        }

        Console.Write(isSimple ? currentNumber + " " : "");
    }

}

Console.Write("Введите число: ");
int uNumber = int.Parse(Console.ReadLine()!);

tableOfSimpleNumber(uNumber);