//==========================================
//#38  Задайте массив вещественных чисел. Найдите разницу
//между максимальным и минимальным элементов массива.
//* Отсортируйте массив методом вставки и методом подсчета, а затем найдите
//разницу между первым и последним элементом. Для задачи со звездочкой
//использовать заполнение массива целыми числами.
//==========================================

// Генерация случайного массива.
int[] GenArr(int arrLen, int arrMin, int arrMax)
{
    int[] arr = new int[arrLen];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(arrMin, arrMax);
    }
    return arr;
}

//Печатает одномерный массив
void Print1DArray(int[] array)
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
int[] MaxMinSearch(int[] array)
{
    int[] resArray = new int[2];
    int min = int.MaxValue;
    int max = int.MinValue;
    foreach (int item in array)
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

//Метод сортировки пузырьком
int[] BubleSort(int[] array)
{
    bool sort = true;
    int end = array.Length;
    int temp;
    while (sort)
    {
        sort = false;
        for (int i = 0; i < end - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                sort = true;
            }
        }
        end--;
    }
    return array;
}

//Сортировка методом вставки
int[] InserSort(int[] array)
{
    int temp;
    for (int i = 1; i < array.Length; i++)
        for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
        {
            temp = array[j];
            array[j] = array[j - 1];
            array[j - 1] = temp;
        }
    return array;
}

//Сортировка методом подсчета
int[] CountingSort(int[] array)
{
    int max = int.MinValue; //Определяем минимальное и максимальное значение и создаем вспомогательный массив
    int min = int.MaxValue;
    foreach (int item in array)
    {
        if (item > max)
            max = item;
        if (item < min)
            min= item;
    }


    int[] countArray = new int[max-min + 1];
    

    for (int i = 0; i < array.Length; i++)
    { //заполняем вспомогательный масив
        countArray[array[i]-min]++;
    }

    int k = 0;
    for (int i = 0; i < countArray.Length; i++)
    { //переносим из вспомогательного массива в основной
        while (countArray[i] > 0)
        {
            array[k] = i+min;
            k++;
            countArray[i]--;
        }
    }
    return array;
}

//Основная программа
PrintInfo("Массив целых чисел");
int[] array = GenArr(1000, -1000, 1000); //длина массива , минимальный, максимальный
Print1DArray(array);


int [] arrayForSort  = new int[array.Length];
Array.Copy(array,arrayForSort,array.Length);


DateTime time = DateTime.Now; // только после первого подсчета таймера программа считает адекватно
int[] maxMin = MaxMinSearch(arrayForSort);
string timeMaxMinSearch = (DateTime.Now - time).ToString();
PrintInfo(
    $"Максимальное {maxMin[0]} и минимальное {maxMin[1]} число методом перечисления\n----------"
);


Array.Copy(array,arrayForSort,array.Length); //копируем в новый массив, чтобы не изменять исходный
time = DateTime.Now;
int[] arrayInserSort = InserSort(arrayForSort);
string timeInserSort = (DateTime.Now - time).ToString();
Print1DArray(arrayInserSort);
PrintInfo(
    $"Максимальное {arrayInserSort[arrayInserSort.Length - 1]} и минимальное {arrayInserSort[0]} число после сортировки методом вставки\n----------"
);

Array.Copy(array,arrayForSort,array.Length);
time = DateTime.Now;
int[] arrayCountingSort = CountingSort(arrayForSort);
string timeCountingSort = (DateTime.Now - time).ToString();
Print1DArray(arrayCountingSort);
PrintInfo(
    $"Максимальное {arrayCountingSort[arrayCountingSort.Length - 1]} и минимальное {arrayCountingSort[0]} число после сортировки методом подсчета\n----------"
);

Array.Copy(array,arrayForSort,array.Length);
time = DateTime.Now;
int[] arrayBubleSort = BubleSort(arrayForSort);
string timeBubleSort = (DateTime.Now - time).ToString();
Print1DArray(arrayBubleSort);
PrintInfo(
    $"Максимальное {arrayBubleSort[arrayBubleSort.Length - 1]} и минимальное {arrayBubleSort[0]} число после сортировки методом пузырька\n----------"
);

PrintInfo($"Время выполнения прогона min-max {timeMaxMinSearch} \n----------");
PrintInfo($"Время выполнения сортировки методом вставки {timeInserSort} \n----------");
PrintInfo($"Время выполнения сортировки методом подсчета {timeCountingSort} \n----------");
PrintInfo($"Время выполнения сортировки методом пузырька {timeBubleSort} \n----------");



