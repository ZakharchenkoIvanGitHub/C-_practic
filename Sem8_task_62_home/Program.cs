//==========================================
//#62 Напишите программу, которая заполнит спирально массив
//==========================================

// Генерация спирального 2D массива.
int[,] Gen2DArrSpiral(int countRow, int countColumn)
{
    int[,] arr2D = new int[countRow, countColumn];
    int startCol = 0;
    int finishCol = countColumn - 1;
    int startRow = 0;
    int finishRow = countRow - 1;
    int counter = 1;

    while (startCol <= finishCol && startRow <= finishRow)
    {
        for (int i = startCol; i <= finishCol; i++)
        {
            arr2D[startRow, i] = counter;
            counter++;
        }
        startRow++;

        for (int i = startRow; i <= finishRow; i++)
        {
            arr2D[i, finishCol] = counter;
            counter++;
        }
        finishCol--;

        for (int i = finishCol; i >= startCol; i--)
        {
            arr2D[finishRow, i] = counter;
            counter++;
        }
        finishRow--;

        for (int i = finishRow; i >= startRow; i--)
        {
            arr2D[i, startCol] = counter;
            counter++;
        }
        startCol++;
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
            if(array[i, j]<10)Console.Write("0");
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Основная программа.
Print2DArray(Gen2DArrSpiral(7, 8));
