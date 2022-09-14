//==========================================
//#34  Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//* Отсортировать массив методом пузырька
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

//Прогонаяет массив тестами
int ArrayTest(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (EventTest(item))
        {
            count++;
        }
    }
    return count;
}

//Тест на четное значение
bool EventTest(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
    ;
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


//Метод сортировки пузырьком
int[] SortedBuble(int[] array)
{
    bool sort = true;
    int end = array.Length;
    int temp;
    while (sort)
    {
        sort = false;
        for (int i = 0; i < end - 1; i++)
        {
            if (array[i] < array[i + 1])
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

//выводит строку на печать
void PrintInfo(string line)
{
    Console.WriteLine(line);
}

//Основная программа
PrintInfo("Массив заполненный случайными положительными трёхзначными числами");
int[] array = GenArr(100, 100, 999);
Print1DArray(array);
PrintInfo("Количество чётных чисел в массиве = " + ArrayTest(array));
PrintInfo("Отсортированный пузырьком массив:");
Print1DArray(SortedBuble(array));
