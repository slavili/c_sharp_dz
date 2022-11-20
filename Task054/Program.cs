/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] testArray = CreateArray(
      rows: 5
    , columns: 6
    , minValue: 0
    , maxValue: 20
);
Console.WriteLine("Оригинальный массив:");
PrintArray(testArray);
SortRowsArray(testArray);
Console.WriteLine("Отсортированный массив:");
PrintArray(testArray);

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

//SortRowsArray - функция сортировки строк массива по убыванию
void SortRowsArray(int[,] userArray)
{
    int rows = userArray.GetLength(0);
    int columns = userArray.GetLength(1);
    int tempValue = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = columns; j > 0; j--)
        {
            for (int k = 0; k < j - 1; k++)
            {
                if (userArray[i, k] < userArray[i, k + 1])
                {
                    tempValue = userArray[i, k];
                    userArray[i, k] = userArray[i, k + 1];
                    userArray[i, k + 1] = tempValue;
                }
            }
        }
    }
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