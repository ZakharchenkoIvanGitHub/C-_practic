//==========================================
//#59 Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и
//столбец, на пересечении которых расположен наименьший элемент массива..
//==========================================

// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
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

int[] FreqDicLoad(int[,] array)
{
    int[] dic = new int[10];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dic[array[i, j]]++;
        }
    }
    return dic;
}

//выводит строку на печать
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

void MinFind(int[,] array, ref int x, ref int y)
{
    int min = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] CreateArray(int[,] array, int x, int y)
{
    int[,] res = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int m = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != x)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != y)
                {
                    res[k, m] = array[i, j];
                    m++;
                }
            }
        m = 0;
        k++;    
        }
        
    }
    return res;
}

int[,] arr2D = Gen2DArr(5, 5, 0, 10);
Print2DArray(arr2D);
Console.WriteLine();
int x=-1;
int y=-1;
MinFind(arr2D,ref x,ref y);


Print2DArray(CreateArray(arr2D,x,y));
