/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

double[,] testArray = CreateArray();
PrintArray(testArray);

//CreateArray - функция наполнения массива случайными вещественными числами
double[,] CreateArray(int rows = 3, int columns = 4, int orderOfMagnitude = 10, int roundUpTo = 1)
{
    double[,] array = new double[rows, columns];
    double tempValue = 0;
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempValue = Math.Pow(-1, rnd.Next(2)) * Math.Round(rnd.NextDouble() * orderOfMagnitude, rnd.Next(roundUpTo + 1));
            //При генерации числа иногда генерируется минус ноль, с помощью if решил эту проблему.
            if (Math.Sign(tempValue) == 0)
            {
                tempValue = 0;
            }
            array[i, j] = tempValue;
        }
    }
    return array;
}
//PrintArray - функция вывода массива на монитор
void PrintArray(double[,] array)
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