
//==========================================
//#49  Задайте двумерный массив. Найдите элементы, у которых 
//оба индекса чётные, и замените эти элементы на их квадраты.
//==========================================

// Генерация случайного 2D массива.
int[,] Gen2DArr(int countRow, int countColumn, int arrMin, int arrMax)
{
    int[,] arr2D = new int[countRow, countColumn];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr2D;
}

//Печатает двумерный массив
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Элементы, у которых оба индекса чётные, заменяет на их квадраты.
int [,] Update2DArray(int [,] array){

        for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] *= array[i,j];
        }
    }
    return array;
}

int [,] array = Gen2DArr(8,8,0,10);

Print2DArray(array);
Console.WriteLine();

Print2DArray(Update2DArray(array));