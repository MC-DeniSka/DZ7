// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] Massive()
{
     System.Console.WriteLine("Введите количество строк массива");
     int colomns = Convert.ToInt32(Console.ReadLine());

     System.Console.WriteLine("Введите количество столбцов массива");
     int rows = Convert.ToInt32(Console.ReadLine());

     double [,] massive = new double[colomns,rows];
     for (int i = 0; i < colomns; i++)
     {
        for (int j = 0; j < rows; j++)
        {
            massive [i,j] = new Random().NextDouble()*10;
            massive [i,j] = Math.Round(massive [i,j],1);
        }
     }
     return massive;
}

void PrintArray(double [,] massive)
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


double [,] massive = Massive();
PrintArray(massive);