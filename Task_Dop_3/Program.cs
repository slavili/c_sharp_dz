/*
Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.
*/
//FillArray - функция заполнения массива
int[] FillArray(int lengthArray = 10, int minNumber = 0, int maxNumber = 10)
{

    int[] userArray = new int[lengthArray];
    Random userRand = new Random();
    for (int i = 0; i < lengthArray; i++)
    {
        userArray[i] = userRand.Next(minNumber, maxNumber + 1);
    }
    return userArray;
}
//SearchMinDigit - функция поиска минимального недостающего числа (MEX)
string SearchMinDigit(int[] userArray, bool isDebug = false)
{

    System.Console.WriteLine("Оригинальный массив [" + string.Join(", ", userArray) + "]");

    //сортируем в обратном порядке: 
    //самое минимальное число будет в массиве с самым большим индексом
    int temp;
    for (int j = userArray.Length - 1; j > 0; j--)
    {
        for (int i = 0; i < j; i++)
        {
            if (userArray[i] < userArray[i + 1])
            {
                temp = userArray[i + 1];
                userArray[i + 1] = userArray[i];
                userArray[i] = temp;
            }
        }
        //ищем нужное число, после того как отсортированно как минимум 2 числа
        if (j <= (userArray.Length - 2) && userArray[j] != userArray[j + 1] && userArray[j] - 1 > userArray[j + 1])
        {
            if (isDebug)
            {
                System.Console.WriteLine(userArray[j + 1] + 1);
            }
            else return Convert.ToString(userArray[j + 1] + 1);
        }
    }

    if (isDebug)
    {
        System.Console.WriteLine("Отсортирован массив [" + string.Join(", ", userArray) + "]");
    }
    return "Массив плотный!";
}

int[] arrayOfDigits = FillArray(lengthArray: 20, minNumber: 0, maxNumber: 100);
//int[] arrayOfDigits = { 3, 8, 5, 7, 4, 3, 10, 9, 1, 10 };
//int[] arrayOfDigits = { 2, 8, 5, 7, 4, 3, 10, 9, 1, 10 };
//int[] arrayOfDigits = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//плотный массив
//int[] arrayOfDigits = { -5, 71, 18, 21, -4, 69, -38, -28, 77, 29, -9, -94, 74, -1, -85, 41, 30, -78, 44, 24 };

System.Console.WriteLine("MEX: " + SearchMinDigit(arrayOfDigits, isDebug: false));




