// Двухмерные массивы//
Console.Clear();
Console.WriteLine("1 - Task 46");
Console.WriteLine("2 - Task 48");
Console.WriteLine("3 - Task 49");
Console.WriteLine("4 - Task 51");
Console.WriteLine("5 - Task 50");
Console.WriteLine("6 - Task 45");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task46();
    break;

    case 2:
    Console.Clear();
    Task48();
    break;

    case 3:
    Console.Clear();
    Task49();
    break;

    case 4:
    Console.Clear();
    Task51();
    break;

    case 5:
    Console.Clear();
    Task50();
    break;

    // case 6:
    // Console.Clear();
    // Task45();
    // break;
    
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

static void Task46()
{

//Демонтстрация. Задайте двумерный массив m*n, заполненный случайными числами
//m = 3, n = 4
int[,] array = new int[3, 4];
for ( int i = 0; i < array.GetLength(0); i++)//для перебора массива нужно два цикла for; 1 перебора
//строк, 2 - для перебора столбцов;для определения длины массива используем GetLenght, для строк задаем 
//пространство (0), для столбцов пространсво (1)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        array[i, j] = new Random().Next(-10, 11);//задаем рандомные значения, интервал выбран самостоятельно//
        Console.Write(array[i, j] + " ");
    }
    
}
}


static void Task48()
{
   /* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/
int[,] array = new int[3, 4];
for ( int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i +j;
        Console.Write(array[i, j] + " ");
    }
    
}

}

static void Task49()
{
    /*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
    Например, изначально массив
    выглядел вот так:
    1 4 7 2
    5 9 2 3
    8 4 2 4*/
    int[,] array = new int[3, 4];
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + " ");
        }

    }

    for ( int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            array[i, j] *= array[i, j];
            Console.Write(array[i, j] + " ");    
        }
        
    }
}


static void Task51()
{
    /*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/
    int[,] array = new int[3, 4];
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + " ");
        }

    }

    int Sum = 0;

    for ( int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            Sum += array[i, j];
            
        }
        
    }
    Console.Write(Sum);

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

    Console.WriteLine("Введите искомое число: ");
    int ViewerNumber = Convert.ToInt32(Console.ReadLine());

    int[,] array =  new int[new Random().Next(10, 15), new Random().Next(10, 15)];

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

