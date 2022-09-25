//==========================================
//#56 Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//==========================================

// Выводит строку на печать.
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

// Печатает двумерный массив.
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

// Ищет строку с наименьшей суммой элементов.
int FindMinRow(int[,] array){
int min = int.MaxValue;
int sum = 0;
int res=-1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i, j];
        }
        if (min>sum){
            min=sum;
            res=i+1;
        }
        sum=0;
    }
    return res;
}

// Основная программа.
int[,] array = Gen2DArr(4, 4, 0, 10);
PrintInfo("Исходный массив:");
Print2DArray(array);
PrintInfo("строка с наименьшей суммой элементов: ",FindMinRow(array).ToString());