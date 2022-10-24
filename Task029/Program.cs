/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
Описание:
функция createArray принимает 2 необязательных параметра, 
т.е. они имеют значения по умолчанию: createArray() -массив  будет заполнен автоматически с количеством элементов равным 8.
Меняя данные параметры можно изменить количество элементов массива и/или
сменить автоматическое заполнение массива на ручное.
*/
int[] createArray(int countOfItemArray = 8, bool manualFilling = false)
{
    int[] tempArray = new int[countOfItemArray];

    if (manualFilling)// блок ручного заполнения массива через консоль 
    {
        for (int i = 0; i < countOfItemArray; i++)
        {   //нумерацию сделал по-человечески
            Console.Write($"Введите {i + 1}-й элемент массива (целое число): ");
            tempArray[i] = int.Parse(Console.ReadLine()!);
        }
    }
    else// блок автоматического заполнения массива
    {
        Random tempRandomNumber = new Random();

        for (int i = 0; i < countOfItemArray; i++)
        {
            tempArray[i] = tempRandomNumber.Next(0, 101);
        }
    }
    return tempArray;
}

void printArray(int[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        if (i == 0)//вывод открывающей квадратной скобки и первого элемента
        {
            Console.Write("[" + userArray[i] + ", ");
        }
        else if (i == (userArray.Length - 1))//вывод последнего элемента и закрывающей квадратной скобки
        {
            Console.Write(userArray[i] + "]");
        }
        else// вывод основных элементов
        {
            Console.Write(userArray[i] + ", ");
        }
    }
}

//int[] testArray = createArray(4, true);
//int[] testArray = createArray(manualFilling: true);
//int[] testArray = createArray(countOfItemArray: 15, manualFilling: true);
//int[] testArray = createArray(countOfItemArray: 45);
int[] testArray = createArray();
printArray(testArray);