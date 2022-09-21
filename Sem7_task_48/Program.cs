//==========================================
//#48  Задайте двумерный массив размера m на n, каждый элемент в массиве находится по 
//формуле: Aₘₙ =m+n. Выведите полученный массив на экран.
//==========================================

// Генерация случайного 2D массива.
int[,] Gen2DArrMN(int m, int n)
{
    int[,] arr2D = new int[m, n];


    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = i+j;
        }
    }
    return arr2D;
}

// Печатает двумерный массив.
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Print2DArray(Gen2DArrMN(10,15));
