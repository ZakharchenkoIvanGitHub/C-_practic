//==========================================
//#45  Напишите программу, которая будет создавать копию заданного 
//одномерного массива с помощью поэлементного копирования.
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


//Метод копирования
int[] CopyArray(int[] arr)
{
    int[] outArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        outArray[i] = arr[i];
    }

    return outArray;
}

int [] array = GenArr(10,0,100);
Print1DArray(array);

Print1DArray(CopyArray(array));