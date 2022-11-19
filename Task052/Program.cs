/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] testArray = CreateArray();
PrintArray(testArray);
Console.WriteLine(AverageColumnsArray(testArray));

//AverageColumnsArray - фукнция нахождения среднего арифметического каждого столбца
string AverageColumnsArray(int[,] array)
{
    string resultValue = "Среднее арифметическое каждого столбца: ";
    double tempAverage = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            tempAverage += array[j, i];
        }
        tempAverage = Math.Round(tempAverage / array.GetLength(0), 1);
        resultValue += Convert.ToString(tempAverage) + "; ";
        tempAverage = 0;
    }
    return resultValue;
}
//CreateArray - функция наполнения массива
int[,] CreateArray(int rows = 3, int columns = 4, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}
//PrintArray - функция выведения массива на монитор
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}