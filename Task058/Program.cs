/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] firstMatrix = CreateArray(2, 3);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = CreateArray(3, 4);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
Console.WriteLine("Произведение матриц:");
PrintArray(resultMatrix);


int[,] MatrixMultiplication(int[,] oneMatrix, int[,] twoMatrix)
{
    int[,] resultMatrix = new int[oneMatrix.GetLength(0), twoMatrix.GetLength(1)];
    int tempResult = 0;

    for (int i = 0; i < oneMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < twoMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < twoMatrix.GetLength(0); k++)
            {
                tempResult += oneMatrix[i, k] * twoMatrix[k, j];
            }
            resultMatrix[i, j] = tempResult;
            tempResult = 0;
        }
    }
    return resultMatrix;
}

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
