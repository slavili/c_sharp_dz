/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double distanceBetweenPoints(int[] pointA, int[] pointB, int roundNumber = 2)
{
    double sum = 0;

    for (int i = 0; i < pointA.Length; i++)
    {
        sum += Math.Pow(pointB[i] - pointA[i], 2);
    }

    return Math.Round(Math.Sqrt(sum), roundNumber);
}
int[] A = { 7, -5, 0 };
int[] B = { 1, -1, 9 };

System.Console.WriteLine(distanceBetweenPoints(A, B));