//==========================================
//#37 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
//элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//=========================================
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
int[] MultTask(int[] arr)
{
    int[] arrMult = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        arrMult[i] = arr[i] * arr[arr.Length-1 -i];
    }
    return arrMult;
}

int[] arr = GenArray(50, 1, 1000);

PrintArray(arr);
PrintArray(MultTask(arr));
