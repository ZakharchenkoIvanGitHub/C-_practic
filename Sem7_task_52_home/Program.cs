//==========================================
//#52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
//столбце. * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом
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

// Печатает двумерный массив в цвете по диоганали.
void Print2DArrayDigonalColor(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = GetColorСell(i, j);
            Console.Write(array[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Задает цвет ячейки.
// Принимает индексы, возвращает цвет.
ConsoleColor GetColorСell(int i, int j)
{
    ConsoleColor[] col = new ConsoleColor[]
    {
        ConsoleColor.Black,
        ConsoleColor.Blue,
        ConsoleColor.Cyan,
        ConsoleColor.DarkBlue,
        ConsoleColor.DarkCyan,
        ConsoleColor.DarkGray,
        ConsoleColor.DarkGreen,
        ConsoleColor.DarkMagenta,
        ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow,
        ConsoleColor.Gray,
        ConsoleColor.Green,
        ConsoleColor.Magenta,
        ConsoleColor.Red,
        ConsoleColor.White,
        ConsoleColor.Yellow
    };

    int numCol = (j - i) % col.Length;
    if (numCol < 0)
        numCol = col.Length + numCol;
    return col[numCol];
}

// Считает среднее арифметическое по столбцам.
double[] AverageСolumn(int[,] array2D)
{
    double[] arrayAverage = new double[array2D.GetLength(1)];
    int sum = 0;

    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            sum += array2D[i, j];
        }
        arrayAverage[j] = Math.Round((double)sum / array2D.GetLength(0), 2);
        sum = 0;
    }
    return arrayAverage;
}

// Считает среднее арифметическое по диоганали.
double[] AverageDioganal(int[,] array2D)
{
    double[] arrayAverage = new double[array2D.GetLength(0) + array2D.GetLength(1) - 1];
    int sum = 0;
    int iStart = array2D.GetLength(0) - 1;
    int iFinish = array2D.GetLength(0);
    int jStart = 0;
    int j = 0;
    int n = 0;

    for (int k = 0; k < array2D.GetLength(0) + array2D.GetLength(1) - 1; k++)
    {
        for (int i = iStart; i < iFinish; i++)
        {
            sum = sum + array2D[i, j];
            n++;
            j++;
        }

        iStart--;
        if (iStart < 0)
        {
            iStart = 0;
            jStart++;
        }
        if (j > array2D.GetLength(1) - 1)
            iFinish--;

        j = jStart;
        arrayAverage[k] = Math.Round((double)sum / n, 2);
        sum = 0;
        n = 0;
    }

    return arrayAverage;
}

// Печатает одномерный массив в цвете по последней строке массива.
void Print1DArrayColor(string message, double[] array, int row)
{
    int i;
    Console.Write(message);
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.ForegroundColor = GetColorСell(row - 1, i);
        Console.Write(array[i] + " ");
        Console.ResetColor();
    }
    Console.ForegroundColor = GetColorСell(row - 1, i);
    Console.WriteLine(array[array.Length - 1]);
    Console.ResetColor();
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

int[,] arr2D = Gen2DArr(row, column, 10, 100);
Print2DArrayDigonalColor(arr2D);

Print1DArrayColor("Среднее арифметическое по столбцам: ", AverageСolumn(arr2D), row);
Print1DArrayColor("Среднее арифметическое по диогонали: ", AverageDioganal(arr2D), row);
