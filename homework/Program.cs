Console.Clear();
Console.WriteLine("1 - Task 47");
Console.WriteLine("2 - Task 50");
Console.WriteLine("3 - Task 52");
// // Console.WriteLine("4 - Task 51");
// // Console.WriteLine("5 - Task 50");

int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task47();
    break;

    case 2:
    Console.Clear();
    Task50();
    break;

    case 3:
    Console.Clear();
    Task52();
    break;

//     // case 4:
//     // Console.Clear();
//     // Task51();
//     // break;

//     // case 5:
//     // Console.Clear();
//     // Task50();
//     // break;

        
    default:
    Console.WriteLine("Номер задачи введен неверно");
    break;
    
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


static void Task50()
{
        // напишите прогармму, которая на вход принимает значение 
        //элемента в двухмерном массиве, и возвращает позицию этого элемента
        // или указание, что такого элемента нет
        //например, задан массив
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 - такого значения нет

        Console.WriteLine("Введите значение элемента: ");
        int ViewerNumber = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[new Random().Next(1, 11), new Random().Next(1, 11)];

        void FillArray(int[,] array)
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

        void Viewer(int[,] array, int ViewerNumber)
        {
    
            int count = 0;
            for ( int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == ViewerNumber)

                    Console.WriteLine($"Искомый элемент на позиции {i}, {j}");
                    else
                    count++;
                }
                
            }
            if (count == array.GetLength(0) * array.GetLength(1))
                Console.WriteLine("Искомого значения нет");
        }
        FillArray(array);
        Console.WriteLine();
        Viewer(array, ViewerNumber);
}

static void Task52()
{
    /*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
    элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

    int[,] array = new int[4, 4];//размер просто написала, тк иного не задано условиями
    
    void FillArray(int[,] array)
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

    void ArithmeticMean(int[,] array)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                double sum = 0;
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum += array[i, j];
                }
                Console.Write($"{ sum / array.GetLength(0)} ");
            }
        

            
           // Console.WriteLine($"Средняя арифметическая по столбцу {count} равна {Sum / count},{Sum % count}");                

        
        
        
        
        
    }

    
    FillArray(array);
    ArithmeticMean(array);
}
