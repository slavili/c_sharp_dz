/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
//FillArray - функция наполнения массива
int[] FillArray(int lengthArray = 10, int minNumber = 1, int maxNumber = 1000)
{

    int[] userArray = new int[lengthArray];
    Random userRand = new Random();
    for (int i = 0; i < lengthArray; i++)
    {
        userArray[i] = userRand.Next(minNumber, maxNumber + 1);
    }
    return userArray;
}
//DiffBetweenMaxMin - функция вычисления разности между max и min
int DiffBetweenMaxMin(int[] userArray)
{
    int maxValue = userArray[0];
    int minValue = userArray[0];

    for (int i = 1; i < userArray.Length; i++)
    {
        if (userArray[i] > maxValue)
        {
            maxValue = userArray[i];
        }
        else if (userArray[i] < minValue)
        {
            minValue = userArray[i];
        }
    }
    return maxValue - minValue;
}

int[] arrayOfDigits = FillArray();

Console.WriteLine("Оригинальный массив: [" + string.Join(", ", arrayOfDigits) + "]");
Console.WriteLine("Разность м/у Max и Min значениями = " + DiffBetweenMaxMin(arrayOfDigits));