/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

string str = string.Empty;
string userS = string.Empty;
//FillString - функция наполнения строки-массива
void FillString(string userString)
{
    int tempInt = 0;
    if (int.TryParse(userString, out tempInt))
    {
        str += tempInt + " ";
    }
}

//CountDigitGreaterThanZero - функция подсчитывает количество цифр больше нуля
int CountDigitGreaterThanZero(string userString)
{
    string tempString = string.Empty;
    int countDigit = 0;
    for (int i = 0; i < userString.Length; i++)
    {
        if (userString[i] != ' ')
        {
            tempString += userString[i];
        }
        else
        {
            if (int.Parse(tempString) > 0) countDigit++;
            tempString = string.Empty;

        }
    }
    return countDigit;
}

Console.WriteLine("Допускаются только целочисленные значения и символ q, остальные будут игнорироваться.");
Console.WriteLine("Для завершения введите символ q.");

do
{
    Console.Write("Введите число: ");
    userS = Console.ReadLine()!;
    FillString(userS);
}
while (userS != "q");

Console.WriteLine("Кол-во цифр больше нуля = " + CountDigitGreaterThanZero(str));
