//==========================================
//#32 Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//=========================================

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
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

// изменяем массив
int[] ChangeArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int arrLength = ReadData("Введите длину массива: ");
int start = ReadData("Введите минимальное значение: ");
int stop = ReadData("Введите максимальное значение: ");

int[] arr =  GenArray(arrLength, start, stop);
PrintArray(arr);
PrintArray(ChangeArr(arr));

//анатолий
/* // Генерация случайного массива.
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

// Печать массива
void PrintArr(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}


int[] NegotivPositiv(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}



int[] arr = GenArr(10, 5, -5);
PrintArr(arr);

int[] res = NegotivPositiv(arr);
PrintArr(res);
 */