/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exponentiation(int baseOfDegree, int degree)
{
    // любоче число в степени 0 равно единице
    // несмотря на то, что в задаче степень только натуральные числа
    // модуль показателя степени не решит проблему нулевой степени.
    if (degree == 0)
        return 1;

    int result = 1;// по умолчанию 1, т.к. будет умножение и 1 не влияет на умножение.

    // модуль числа любое отрицательное число делает натуральным
    degree = Math.Abs(degree);

    for (int i = 0; i < degree; i++)
    {
        result *= baseOfDegree;
    }
    return result;
}


Console.Write("Введите основание степени: ");
int baseOfDegree = int.Parse(Console.ReadLine()!);
Console.Write("Введите показатель степени(будет взят модуль числа): ");
int degree = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{baseOfDegree}^{Math.Abs(degree)} = " + Exponentiation(baseOfDegree, degree));