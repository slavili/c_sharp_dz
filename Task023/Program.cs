/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void tableOfCubes(int userNumber, int degree = 3)
{

    for (int i = 1; i <= userNumber; i++)// счётчик с 1, т.к. возводить 0 в степень не имеет смысла
    {
        int result = 1;// каждый раз приводим result к нейтральному состоянию

        for (int j = 0; j < degree; j++)
        {
            result *= i;
        }
        Console.Write(result + " ");
    }

}

Console.Write("Введите число: ");
int uNumber = int.Parse(Console.ReadLine()!);
tableOfCubes(uNumber);