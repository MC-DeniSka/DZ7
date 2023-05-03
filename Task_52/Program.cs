// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverageMean(int [,] massive )
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            sum += massive[i,j];
        }
        double avg = sum / massive.GetLength(0);
        System.Console.WriteLine(Math.Round(avg,1));
    }
}


int [,] massive = Massive();
PrintArray(massive);
FindAverageMean(massive);