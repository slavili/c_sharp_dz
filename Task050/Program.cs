/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] testArray = CreateArray();
PrintArray(testArray);
Console.WriteLine(SearchArrayElement(testArray, 2, 1));


//SearchArrayElement - функция поиска элемента массива
string SearchArrayElement(int[,] array, int row = 0, int column = 0)
{

    if ((row >= 0 && row < array.GetLength(0)) && (column >= 0 && column < array.GetLength(1)))
    {
        return Convert.ToString(array[row, column]);
    }
    return "Такого числа в массиве нет.";
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
