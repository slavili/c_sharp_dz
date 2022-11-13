/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

При обсуждении на практических занятиях пришли к общему мнению, что нумерацию нужно условно сдвинуть, т.е. начинаем считать не с 0 элементы массива, а с 1.
Тогда вышеуказанные примеры не верны, или я что-то недопонял. Но сделал как сделал.
*/
//FillArray - функция наполнения массива
int[] FillArray(int lengthArray = 10, int minNumber = -100, int maxNumber = 100)
{

    int[] userArray = new int[lengthArray];
    Random userRand = new Random();
    for (int i = 0; i < lengthArray; i++)
    {
        userArray[i] = userRand.Next(minNumber, maxNumber + 1);
    }
    return userArray;
}
//SumValueOfItems - функция подсчёта суммы элементов на нечётных позициях
int SumValueOfItems(int[] userArray)
{
    int sumTemp = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if ((i + 1) % 2 != 0)
        {
            sumTemp += userArray[i];
        }
    }
    return sumTemp;
}

int[] arrayOfDigits = FillArray();

Console.WriteLine("Оригинальный массив: [" + string.Join(", ", arrayOfDigits) + "]");
Console.WriteLine("Сумма элементов на нечётных позициях = " + SumValueOfItems(arrayOfDigits));