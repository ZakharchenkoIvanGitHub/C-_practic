//==========================================
//#36  Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//* Найдите все пары в массиве и выведите пользователю
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

//Суммирует элементы, стоящие на нечётных позициях.
int EventSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length - 1; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

//выводит строку на печать
void PrintInfo(string line)
{
    Console.WriteLine(line);
}

//Находит все пары в массиве
int[] PairSearch(int[] array)
{
    List<int> list = new List<int>();
    for (int i = 0; i < array.Length - 2; i++)
    {
        if (list.IndexOf(array[i]) == -1)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[i] == array[j])
                {
                    list.Add(array[i]);
                    break;
                }
            }
        }
    }
    return list.ToArray();
}

//Основная программа
PrintInfo("Массив заполненный случайными положительными трёхзначными числами");
int[] array = GenArr(20, 1, 10);
Print1DArray(array);
PrintInfo("Cумма элементов, стоящих на нечётных позициях. = " + EventSum(array));
PrintInfo("Следующие числа являются парными");
Print1DArray(PairSearch(array));
