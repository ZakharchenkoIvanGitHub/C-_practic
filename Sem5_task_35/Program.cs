//==========================================
//#35 Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//=========================================
// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// считаем числа в массиве
int CountElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            sum++;
        }
    }
    return sum;
}

int[] arr = GenArray(123, 1, 1000);

PrintArray(arr);
PrintResult("В массиве " + CountElem(arr) + " элементов в отрезке [10,99]");
