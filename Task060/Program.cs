/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] testArray = CreateArray();
PrintArray(testArray);

//PrintArray - функция печтаи массива
void PrintArray(int[,,] userArray)
{
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            for (int k = 0; k < userArray.GetLength(2); k++)
            {
                Console.Write(userArray[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
}

//CreateArray - функция создания трёхмерного массива
int[,,] CreateArray(int x = 2, int y = 2, int z = 2)
{
    int[,,] resultArray = new int[x, y, z];
    var rnd = new Random().Next(10, 50);
    int tempValue = rnd;

    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < resultArray.GetLength(2); k++)
            {
                resultArray[i, j, k] = tempValue++;
            }
        }
    }
    return resultArray;
}