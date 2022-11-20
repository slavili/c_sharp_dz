/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] testArray = CreateArray(
      rows: 10
    , columns: 3
    , minValue: 0
    , maxValue: 3
);
Console.WriteLine("Оригинальный массив:");
PrintArray(testArray);
Console.Write("Строки с минимальной суммой имеют номера: ");
Console.Write(MinSumElementsRowsOfArray(testArray));

//CreateArray - функция создания и наполнения массива
int[,] CreateArray(int rows = 3, int columns = 4, int minValue = 0, int maxValue = 10)
{
    int[,] tempArray = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            tempArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return tempArray;
}

//PrintArray - функция вывода массива на монитор
void PrintArray(int[,] userArray)
{
    int rows = userArray.GetLength(0);
    int columns = userArray.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(userArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//MinSumElementsRowsOfArray - функция возвращающая строки с минимальной суммой
string MinSumElementsRowsOfArray(int[,] userArray)
{
    int rows = userArray.GetLength(0);
    int columns = userArray.GetLength(1);
    int[] lineNumber = new int[rows];
    int tempSum = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            tempSum += userArray[i, j];
        }
        lineNumber[i] = tempSum;
        tempSum = 0;
    }

    int min = lineNumber[0];

    for (int i = 1; i < lineNumber.Length; i++)
    {
        if (min > lineNumber[i])
        {
            min = lineNumber[i];
        }
    }

    string resultRows = string.Empty;

    for (int i = 0; i < lineNumber.Length; i++)
    {
        if (min == lineNumber[i])
        {
            resultRows += i + " ";
        }
    }

    return resultRows;
}