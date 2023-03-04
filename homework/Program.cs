Console.Clear();
Console.WriteLine("1 - Task 47");
// Console.WriteLine("2 - Task 48");
// Console.WriteLine("3 - Task 49");
// Console.WriteLine("4 - Task 51");
// Console.WriteLine("5 - Task 50");

int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task47();
    break;

    // case 2:
    // Console.Clear();
    // Task48();
    // break;

    // case 3:
    // Console.Clear();
    // Task49();
    // break;

    // case 4:
    // Console.Clear();
    // Task51();
    // break;

    // case 5:
    // Console.Clear();
    // Task50();
    // break;

        
    // default:
    // Console.WriteLine("Номер задачи введен неверно");
    // break;
    
}

static int Prompt(string massage)//метод запроса числа
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task47()
{
    /*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9*/

    double[,] array =  new double[3, 4];

    void FillArray(double[,] array)
    {
         for ( int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-10, 11);
                Console.Write(array[i, j] + " ");
            }
        }
    }
    FillArray(array);
}
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
