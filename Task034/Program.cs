/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
//FillArray - функция наполнения массива
int[] FillArray(int lengthArray = 10, int minNumber = 100, int maxNumber = 999)
{
    int[] userArray = new int[lengthArray];
    Random userRand = new Random();
    for (int i = 0; i < lengthArray; i++)
    {
        userArray[i] = userRand.Next(minNumber, maxNumber + 1);
    }
    return userArray;
}
//NumberOfEvenDigits - функция подсчёта чётных чисел в массиве
int NumberOfEvenDigits(int[] userArray)
{
    int tempCount = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] % 2 == 0)
        {
            tempCount++;
        }
    }
    return tempCount;
}
int[] arrayOfDigits = FillArray();

Console.WriteLine("Оригинальный массив: [" + string.Join(", ", arrayOfDigits) + "]");
Console.WriteLine("Кол-во чётных чисел в массиве: " + NumberOfEvenDigits(arrayOfDigits));