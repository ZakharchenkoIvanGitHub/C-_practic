//==========================================
//#38  Задайте массив вещественных чисел. Найдите разницу
//между максимальным и минимальным элементов массива.
//* Отсортируйте массив методом вставки и методом подсчета, а затем найдите
//разницу между первым и последним элементом. Для задачи со звездочкой
//использовать заполнение массива целыми числами.
//==========================================

// Генерация случайного массива.
double[] GenArr(int arrLen, int arrMin, int arrMax)
{
    double[] arr = new double[arrLen];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(arrMin, arrMax) * rnd.NextDouble();
    }
    return arr;
}

//Печатает одномерный массив
void Print1DArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

//выводит строку на печать
void PrintInfo(string line)
{
    Console.WriteLine(line);
}

//Находит максимальное[0] и минимальное[1] число
double[] MaxMinSearch(double[] array)
{
    double[] resArray = new double[2];
    double min = int.MaxValue;
    double max = int.MinValue;
    foreach (double item in array)
    {
        if (item > max)
            max = item;
        if (item < min)
            min = item;
    }

    resArray[0] = max;
    resArray[1] = min;
    return resArray;
}

//Основная программа
PrintInfo("Массив вещественных чисел");
double[] array = GenArr(20, 1, 100);
Print1DArray(array);
double[] maxMin = MaxMinSearch(array);

PrintInfo(
    $"Разница между максимальным {maxMin[0]} и минимальным {maxMin[1]} числами равна {maxMin[0] - maxMin[1]}"
);
