// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] Massive()
{
     System.Console.WriteLine("Введите количество строк массива");
     int colomns = Convert.ToInt32(Console.ReadLine());

     System.Console.WriteLine("Введите количество столбцов массива");
     int rows = Convert.ToInt32(Console.ReadLine());

     int [,] massive = new int[colomns,rows];
     for (int i = 0; i < colomns; i++)
     {
        for (int j = 0; j < rows; j++)
        {
            massive [i,j] = new Random().Next(1,10);
        }
     }
     return massive;
}

void PrintArray(int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write(massive[i,j]+" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindNumber(int [,] massive)
{
    System.Console.WriteLine("Введите строку");
    int row = Convert.ToInt32(Console.ReadLine())-1;
    System.Console.WriteLine("Введите столбец");
    int colomn = Convert.ToInt32(Console.ReadLine())-1;
    if (row < 0 | row > massive.GetLength(0)-1 | colomn < 0 | colomn > massive.GetLength(1)-1)
    {
        System.Console.WriteLine("Ошибка! такого элемента нет!");
    }
    else
    {
        System.Console.WriteLine("Значение элемента массива = {0}",massive[row,colomn]);
    }
}


int [,] massive = Massive();
PrintArray(massive);
FindNumber(massive);