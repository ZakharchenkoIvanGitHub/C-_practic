using System;

//==========================================
//#51  Задайте двумерный массив. Найдите сумму элементов, находящихся
//на главной диагонали (с индексами (0,0); (1;1) и т.д.
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Сумма элементов главной диаглнали
int DioganalSum(int[,] array)
{
    int sum=0;
    int len = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
    for (int i = 0; i<len;i++){
        sum+=array[i,i];
    }
    return sum;
}

//выводит строку на печать
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}
int [,] array = Gen2DArr(6,7,0,10);
Print2DArray(array);
PrintInfo("Сумма элементов главной диагонали " , DioganalSum(array).ToString());