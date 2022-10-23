/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
Алгоритм(словесный):
необходимо сравнивать первую цифру с последней, вторую с предпоследней
Цикло должен повторяться кол-во символов поделённое на 2 и округлённое в меньшую сторону.
*/
bool isPolindrom(int userDigit)
{
    bool isP = true;
    //Возьмём модуль числа и переведём в строку и будем работать как с массивом
    string tempValue = Convert.ToString(Math.Abs(userDigit));
    // отсекаем числа менше 10
    if (tempValue.Length < 2)
        return false;

    int countOfCycle = tempValue.Length / 2;// расчитываем кол-во циклов
    int numberLastItem = tempValue.Length - 1;//вычисляем номер последнего элемента
    // если полиндром, то цикл полностью отрабатывает, если нет, 
    // то прерывается на первом же несоответствии.
    for (int i = 0; isP && i < countOfCycle; i++)
    {
        isP = tempValue[i] == tempValue[numberLastItem - i];
    }
    return isP;
}

void printPolindrom(bool userFunction)
{
    Console.WriteLine(userFunction ? "Полиндром" : "НЕ полиндром");
}
Console.Write("Введите число меньше -10 или больше 10: ");
int userDigit = Convert.ToInt32(Console.ReadLine()!);
printPolindrom(isPolindrom(userDigit));





