/*
Дополнительно. Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1. 

Принял решение динамически заполнять массив и искать первое вхождение числа в массив.
*/
//FillArray - функция наполнения массива
int[] FillArray(int lengthArray = 10, int minNumber = 1, int maxNumber = 10)
{

    int[] userArray = new int[lengthArray];
    Random userRand = new Random();
    for (int i = 0; i < lengthArray; i++)
    {
        userArray[i] = userRand.Next(minNumber, maxNumber + 1);
    }
    return userArray;
}
//SearchValueInArray - функция поиска числа в массиве и возвращения его индекса
int SearchValueInArray(int userNumber, int[] userArray)
{
    int index = -1;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userNumber == userArray[i])
        {
            index = i;
            break;
        }
    }
    return index;
}

int[] arrayOfDigits = FillArray();
int userNumber = 10;
int searchIndex = SearchValueInArray(userNumber, arrayOfDigits);
Console.WriteLine("Оригинальный массив: [" + string.Join(", ", arrayOfDigits) + "]");
Console.WriteLine(searchIndex == -1 ? $"Число {userNumber} не найдено в массиве." : $"Число {userNumber} найдено в массиве. Его индекс = {searchIndex}");
