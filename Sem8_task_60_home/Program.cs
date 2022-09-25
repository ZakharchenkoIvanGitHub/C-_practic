//==========================================
//#60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//==========================================

// Генерация случайного 3D массива.
int[,,] Gen3DArr(int countRow, int countColumn, int countDepth, int arrMin, int arrMax)
{
    int[,,] arr3D = new int[countRow, countColumn, countDepth];
    Random rnd = new Random();
    int data;

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(1); k++)
            {
                do
                {
                    data = rnd.Next(arrMin, arrMax);
                } while (CheckingRepetitions(arr3D, countRow, countColumn, countDepth, data));

                arr3D[i, j, k] = data;
            }
        }
    }
    return arr3D;
}

// Проверка на повторяющиеся значения.
bool CheckingRepetitions(int[,,] arr3D, int iMax, int jMax, int kMax, int data)
{
    for (int i = 0; i < iMax; i++)
    {
        for (int j = 0; j < jMax; j++)
        {
            for (int k = 0; k < kMax; k++)
            {
                if (arr3D[i, j, k] == data)
                    return true;
                if (arr3D[i, j, k] == 0)
                    return false;
            }
        }
    }
    return false;
}

// Печатает трехмерный массив с индексами.
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Основная программа.
Print3DArray(Gen3DArr(4, 4, 4, 10, 100));
