//==========================================
//#54 Задайте двумерный массив. Напишите программу, которая упорядочит
//по убыванию элементы каждой строки двумерного массива.
//==========================================

//выводит строку на печать
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Обновляет массив
int[,] UpdateArray(int[,] array)
{
    List<int> data = new List<int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            data.Add(array[i, j]);
        }
        data.Sort();
        data.Reverse();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = data[j];
        }
        data.Clear();
    }
    return array;
}

//Основная программа
int[,] array = Gen2DArr(10, 10, 0, 10);
PrintInfo("Исходный массив:");
Print2DArray(array);
PrintInfo("\n","Отсортированный массив: ");
Print2DArray(UpdateArray(array));
