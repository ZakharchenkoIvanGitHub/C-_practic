//==========================================
//#39  Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
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


//Метод разворота массива с созданием нового массива
int[] SwapNewArray(int[] arr)
{
    int[] outArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        outArray[i] = arr[arr.Length - 1 - i];
    }

    return outArray;
}

//Метод разворота массива
int[] SwapArray(int[] arr)
{
    int bufElement = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }

    return arr;
}

int[] arr = GenArr(20, 1, 100);
Console.WriteLine("Исходный массив");
Print1DArray(arr);

int[] copyArray = SwapNewArray(arr);
Console.WriteLine("Новый перевернутый массив");
Print1DArray(copyArray);

Console.WriteLine("Исходный массив");
Print1DArray(arr);

Console.WriteLine("Перевернутый массив");
SwapArray(arr);
Print1DArray(arr);
