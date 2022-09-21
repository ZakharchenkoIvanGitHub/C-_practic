//==========================================
//#50  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание, что такого элемента нет.
//==========================================

// Запрос данных пользователяю, принимает строку заголовок.
//Выдает введеное число, в случае ошибки выдает 0
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

// Выдает число Фибоначи
double Fibonachi(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return Fibonachi(n - 1) + Fibonachi(n - 2);
}

// Генерация 2D массива числами фибоначи.
double[,] Gen2DArrFibonaci(int countRow, int countColumn)
{
    double first = 1;
    double last = 1;
    double buf = 0;
    double[,] arr2D = new double[countRow, countColumn];

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = first;
            buf = first + last;
            first = last;
            last = buf;
        }
    }
    return arr2D;
}

//Получаем шириyу столбцов
int[] GetСolumnWidth(double[,] array)
{
    int[] arrayLen = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        arrayLen[i] = (int)Math.Log10(array[array.GetLength(1) - 1, i]) + 1;
    }
    return arrayLen;
}

//Возвращает строку с заданным количеством символов
string GetMultiChar(char symbol, int multiplier)
{
    return new(symbol, multiplier);
}

// Печатает двумерный массив чисел фибоначи, выделяет ячейку x,y.
void PrintMatrixFibonachi(double[,] array, int x = -1, int y = -1)
{
    int[] arrayLen = GetСolumnWidth(array); // Ширина столбца

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x && y == j)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(
                array[i, j] + GetMultiChar(' ', arrayLen[j] - (int)Math.Log10(array[i, j]))
            );
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Ищет элемент х,у в массиве array
double FindElement(int x, int y, double[,] array)
{
    if (x < array.GetLength(0) && y < array.GetLength(1))
    {
        return array[x, y];
    }
    else
        return -1;
}

//Выводит найденый элемент на печать, возвращает истину если элемент существует
bool PrintElement(double element)
{
    if (element == -1)
    {
        Console.WriteLine("Такого элемента не существует");
        return false;
    }
    else
    {
        Console.WriteLine("Запрашиваемый элемент = " + element);
        return true;
    }
}

// Основная программа
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

double[,] arrayFibonachi = Gen2DArrFibonaci(row, column);
PrintMatrixFibonachi(arrayFibonachi);

Console.WriteLine("Какой элемент необходимо найти? Начальный элемент [0,0]");
int x = ReadData("Введите строку ");
int y = ReadData("Введите столбец ");

if (PrintElement(FindElement(x, y, arrayFibonachi)))
{
    PrintMatrixFibonachi(arrayFibonachi, x, y);
}
;
